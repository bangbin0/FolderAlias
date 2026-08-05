using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;



namespace Name2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 绑定按钮事件
            button1.Click += BtnSelectFolder;
            button2.Click += BtnSave;
            button3.Click += BtnViewIni;
        }

        // 选择文件夹（兼容C#7.3，移除using声明）
        private void BtnSelectFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            try
            {
                dialog.Description = "请选择需要设置别名的文件夹";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.SelectedPath;
                    textBox1.Text = path;
                    txtAlias.Clear();

                    string iniPath = Path.Combine(path, "desktop.ini");
                    if (File.Exists(iniPath))
                    {
                        // ANSI 读取配置
                        string content = File.ReadAllText(iniPath, Encoding.Default);
                        string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string line in lines)
                        {
                            string trimLine = line.Trim();
                            if (trimLine.StartsWith("LocalizedResourceName="))
                            {
                                string name = trimLine.Substring("LocalizedResourceName=".Length).Trim();
                                txtAlias.Text = name;
                                break;
                            }
                        }
                    }
                }
            }
            finally
            {
                dialog.Dispose();
            }
        }

        // 保存 desktop.ini
        private void BtnSave(object sender, EventArgs e)
        {
            string folderPath = textBox1.Text.Trim();
            string alias = txtAlias.Text.Trim();
            string tipText = txtInfoTip.Text.Trim();

            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("请先选择文件夹！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(alias))
            {
                MessageBox.Show("请填写自定义别名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string iniFile = Path.Combine(folderPath, "desktop.ini");
            // 新增InfoTip配置行，带注释
            string content = $@"[.ShellClassInfo]
;自定义文件夹显示别名，修改此行即可更改文件夹名称
LocalizedResourceName={alias}
;鼠标悬浮文件夹显示的提示文本
InfoTip={tipText}";

            try
            {
                Encoding ansi = Encoding.Default;
                File.WriteAllText(iniFile, content, ansi);

                // desktop.ini 设置系统+隐藏
                ProcessStartInfo iniCmd = new ProcessStartInfo
                {
                    FileName = "attrib.exe",
                    Arguments = $"+s +h \"{iniFile}\"",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                using (Process p1 = Process.Start(iniCmd))
                {
                    p1.WaitForExit();
                }

                // 文件夹设置系统属性
                ProcessStartInfo dirCmd = new ProcessStartInfo
                {
                    FileName = "attrib.exe",
                    Arguments = $"+s \"{folderPath}\"",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                using (Process p2 = Process.Start(dirCmd))
                {
                    p2.WaitForExit();
                }

                MessageBox.Show("配置保存完成，资源管理器已刷新！\n重新打开文件夹即可生效", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 浏览现有desktop.ini内容
        private void BtnViewIni(object sender, EventArgs e)
        {
            string folderPath = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("请先选择文件夹", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string iniFile = Path.Combine(folderPath, "desktop.ini");
            if (!File.Exists(iniFile))
            {
                MessageBox.Show("该文件夹未创建desktop.ini", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // 读取必须和写入保持一致：ANSI(Encoding.Default)
                string txt = File.ReadAllText(iniFile, Encoding.Default);
                Form preview = new Form
                {
                    Text = "desktop.ini 预览",
                    Size = new System.Drawing.Size(460, 260),
                    StartPosition = FormStartPosition.CenterParent
                };
                TextBox tb = new TextBox
                {
                    Dock = DockStyle.Fill,
                    Multiline = true,
                    ReadOnly = true,
                    Font = new System.Drawing.Font("Consolas", 10),
                    Text = txt
                };
                preview.Controls.Add(tb);
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"读取失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
