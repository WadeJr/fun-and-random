namespace SkipBo
{
    partial class Main
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
            this.ClientBtn = new System.Windows.Forms.Button();
            this.HostBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientBtn
            // 
            this.ClientBtn.Location = new System.Drawing.Point(470, 65);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(196, 104);
            this.ClientBtn.TabIndex = 3;
            this.ClientBtn.Text = "Client";
            this.ClientBtn.UseVisualStyleBackColor = true;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
            // 
            // HostBtn
            // 
            this.HostBtn.Location = new System.Drawing.Point(146, 65);
            this.HostBtn.Name = "HostBtn";
            this.HostBtn.Size = new System.Drawing.Size(196, 104);
            this.HostBtn.TabIndex = 2;
            this.HostBtn.Text = "Host";
            this.HostBtn.UseVisualStyleBackColor = true;
            this.HostBtn.Click += new System.EventHandler(this.HostBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 232);
            this.Controls.Add(this.ClientBtn);
            this.Controls.Add(this.HostBtn);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkipBo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.Button HostBtn;
    }
}

