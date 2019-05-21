namespace SCP_FileTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.recieveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.sshTxt = new System.Windows.Forms.TextBox();
            this.fpTxt = new System.Windows.Forms.TextBox();
            this.localFpTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // recieveBtn
            // 
            this.recieveBtn.Location = new System.Drawing.Point(309, 345);
            this.recieveBtn.Name = "recieveBtn";
            this.recieveBtn.Size = new System.Drawing.Size(158, 63);
            this.recieveBtn.TabIndex = 1;
            this.recieveBtn.Text = "Recieve";
            this.recieveBtn.UseVisualStyleBackColor = true;
            this.recieveBtn.Click += new System.EventHandler(this.recieveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Net ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Path:";
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(524, 251);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(109, 45);
            this.browseBtn.TabIndex = 4;
            this.browseBtn.Text = "Browse..";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // sshTxt
            // 
            this.sshTxt.Location = new System.Drawing.Point(158, 116);
            this.sshTxt.Name = "sshTxt";
            this.sshTxt.Size = new System.Drawing.Size(220, 31);
            this.sshTxt.TabIndex = 5;
            // 
            // fpTxt
            // 
            this.fpTxt.Location = new System.Drawing.Point(263, 180);
            this.fpTxt.Name = "fpTxt";
            this.fpTxt.Size = new System.Drawing.Size(243, 31);
            this.fpTxt.TabIndex = 6;
            // 
            // localFpTxt
            // 
            this.localFpTxt.Location = new System.Drawing.Point(263, 265);
            this.localFpTxt.Name = "localFpTxt";
            this.localFpTxt.Size = new System.Drawing.Size(243, 31);
            this.localFpTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Local File Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(529, 116);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(220, 31);
            this.passwordTxt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.localFpTxt);
            this.Controls.Add(this.fpTxt);
            this.Controls.Add(this.sshTxt);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recieveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Transfer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button recieveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox sshTxt;
        private System.Windows.Forms.TextBox fpTxt;
        private System.Windows.Forms.TextBox localFpTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTxt;
    }
}

