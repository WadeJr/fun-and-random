namespace ServiceInstall
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
            this.fileTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.installBtn = new System.Windows.Forms.Button();
            this.uninstallBtn = new System.Windows.Forms.Button();
            this.folderTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileTxt
            // 
            this.fileTxt.Location = new System.Drawing.Point(262, 110);
            this.fileTxt.Name = "fileTxt";
            this.fileTxt.Size = new System.Drawing.Size(214, 31);
            this.fileTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "File to install:";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(525, 102);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(131, 47);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search ...";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // installBtn
            // 
            this.installBtn.Location = new System.Drawing.Point(245, 207);
            this.installBtn.Name = "installBtn";
            this.installBtn.Size = new System.Drawing.Size(138, 53);
            this.installBtn.TabIndex = 3;
            this.installBtn.Text = "Install";
            this.installBtn.UseVisualStyleBackColor = true;
            this.installBtn.Click += new System.EventHandler(this.installBtn_Click);
            // 
            // uninstallBtn
            // 
            this.uninstallBtn.Location = new System.Drawing.Point(399, 207);
            this.uninstallBtn.Name = "uninstallBtn";
            this.uninstallBtn.Size = new System.Drawing.Size(138, 53);
            this.uninstallBtn.TabIndex = 4;
            this.uninstallBtn.Text = "Uninstall";
            this.uninstallBtn.UseVisualStyleBackColor = true;
            this.uninstallBtn.Click += new System.EventHandler(this.uninstallBtn_Click);
            // 
            // folderTxt
            // 
            this.folderTxt.Location = new System.Drawing.Point(262, 147);
            this.folderTxt.Name = "folderTxt";
            this.folderTxt.Size = new System.Drawing.Size(214, 31);
            this.folderTxt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 298);
            this.Controls.Add(this.folderTxt);
            this.Controls.Add(this.uninstallBtn);
            this.Controls.Add(this.installBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Install";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button installBtn;
        private System.Windows.Forms.Button uninstallBtn;
        private System.Windows.Forms.TextBox folderTxt;
    }
}

