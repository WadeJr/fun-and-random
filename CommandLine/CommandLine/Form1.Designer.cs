namespace CommandLine
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.consoleTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(537, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(245, 100);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Console";
            // 
            // consoleTxt
            // 
            this.consoleTxt.Location = new System.Drawing.Point(42, 208);
            this.consoleTxt.Multiline = true;
            this.consoleTxt.Name = "consoleTxt";
            this.consoleTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleTxt.Size = new System.Drawing.Size(1261, 652);
            this.consoleTxt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 902);
            this.Controls.Add(this.consoleTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command Line";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox consoleTxt;
    }
}

