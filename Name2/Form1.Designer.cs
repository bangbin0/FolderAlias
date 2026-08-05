
namespace Name2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelPathTip = new System.Windows.Forms.Label();
            this.labelAliasTip = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.labelInfoTip = new System.Windows.Forms.Label();
            this.txtInfoTip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(409, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "📂 选择目标文件夹";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(411, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "💾 保存";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(301, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "👁 浏览配置";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // labelPathTip
            // 
            this.labelPathTip.AutoSize = true;
            this.labelPathTip.Location = new System.Drawing.Point(12, 81);
            this.labelPathTip.Name = "labelPathTip";
            this.labelPathTip.Size = new System.Drawing.Size(77, 12);
            this.labelPathTip.TabIndex = 4;
            this.labelPathTip.Text = "文件夹路径：";
            // 
            // labelAliasTip
            // 
            this.labelAliasTip.AutoSize = true;
            this.labelAliasTip.Location = new System.Drawing.Point(12, 138);
            this.labelAliasTip.Name = "labelAliasTip";
            this.labelAliasTip.Size = new System.Drawing.Size(77, 12);
            this.labelAliasTip.TabIndex = 5;
            this.labelAliasTip.Text = "文件夹别名：";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(12, 153);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(283, 21);
            this.txtAlias.TabIndex = 6;
            // 
            // labelInfoTip
            // 
            this.labelInfoTip.AutoSize = true;
            this.labelInfoTip.Location = new System.Drawing.Point(12, 186);
            this.labelInfoTip.Name = "labelInfoTip";
            this.labelInfoTip.Size = new System.Drawing.Size(65, 12);
            this.labelInfoTip.TabIndex = 7;
            this.labelInfoTip.Text = "悬浮提示：";
            // 
            // txtInfoTip
            // 
            this.txtInfoTip.Location = new System.Drawing.Point(12, 201);
            this.txtInfoTip.Name = "txtInfoTip";
            this.txtInfoTip.Size = new System.Drawing.Size(283, 21);
            this.txtInfoTip.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 252);
            this.Controls.Add(this.labelInfoTip);
            this.Controls.Add(this.txtInfoTip);
            this.Controls.Add(this.labelAliasTip);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.labelPathTip);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件夹别名配置工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelPathTip;
        private System.Windows.Forms.Label labelAliasTip;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelInfoTip;
        private System.Windows.Forms.TextBox txtInfoTip;
    }
}

