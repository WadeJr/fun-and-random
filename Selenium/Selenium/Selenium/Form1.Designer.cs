namespace Selenium
{
    partial class Selenium
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startBtn = new System.Windows.Forms.Button();
            this.urlText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.consoleTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stopResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(2252, 47);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(208, 69);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(761, 66);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(451, 31);
            this.urlText.TabIndex = 1;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(1495, 66);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(451, 31);
            this.idText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Url:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1429, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // consoleTxt
            // 
            this.consoleTxt.Location = new System.Drawing.Point(127, 233);
            this.consoleTxt.Multiline = true;
            this.consoleTxt.Name = "consoleTxt";
            this.consoleTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleTxt.Size = new System.Drawing.Size(2599, 1077);
            this.consoleTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1361, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Console";
            // 
            // stopResetBtn
            // 
            this.stopResetBtn.Location = new System.Drawing.Point(2504, 47);
            this.stopResetBtn.Name = "stopResetBtn";
            this.stopResetBtn.Size = new System.Drawing.Size(208, 69);
            this.stopResetBtn.TabIndex = 7;
            this.stopResetBtn.Text = "Stop";
            this.stopResetBtn.UseVisualStyleBackColor = true;
            this.stopResetBtn.Click += new System.EventHandler(this.stopResetBtn_Click);
            // 
            // Selenium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2884, 1579);
            this.Controls.Add(this.stopResetBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.consoleTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.startBtn);
            this.Name = "Selenium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selenium";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Selenium_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox consoleTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button stopResetBtn;
    }
}

