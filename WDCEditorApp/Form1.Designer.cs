namespace WDCEditorApp
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
            this.ucFirstControl1 = new WDCCustom.Controls.Bases.UcFirstControl();
            this.ucButton1 = new WDCCustom.Controls.Buttons.UcButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ucFirstControl1
            // 
            this.ucFirstControl1.Location = new System.Drawing.Point(332, 95);
            this.ucFirstControl1.Name = "ucFirstControl1";
            this.ucFirstControl1.Size = new System.Drawing.Size(196, 30);
            this.ucFirstControl1.TabIndex = 1;
            this.ucFirstControl1.Text = "ucFirstControl1";
            this.ucFirstControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucButton1
            // 
            this.ucButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucButton1.Location = new System.Drawing.Point(221, 60);
            this.ucButton1.Name = "ucButton1";
            this.ucButton1.Size = new System.Drawing.Size(82, 23);
            this.ucButton1.TabIndex = 2;
            this.ucButton1.Text = "ucButton1";
            this.ucButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucButton1);
            this.Controls.Add(this.ucFirstControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private WDCCustom.Controls.Bases.UcFirstControl ucFirstControl1;
        private WDCCustom.Controls.Buttons.UcButton ucButton1;
    }
}

