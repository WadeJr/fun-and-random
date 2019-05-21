namespace CardCounting
{
    partial class Cards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cards));
            this.HostTxt = new System.Windows.Forms.TextBox();
            this.PortTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartStopBtn = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.SuspendLayout();
            // 
            // HostTxt
            // 
            this.HostTxt.Location = new System.Drawing.Point(320, 89);
            this.HostTxt.Name = "HostTxt";
            this.HostTxt.Size = new System.Drawing.Size(150, 31);
            this.HostTxt.TabIndex = 0;
            this.HostTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PortTxt
            // 
            this.PortTxt.Location = new System.Drawing.Point(317, 152);
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(150, 31);
            this.PortTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StartStopBtn
            // 
            this.StartStopBtn.Location = new System.Drawing.Point(323, 219);
            this.StartStopBtn.Name = "StartStopBtn";
            this.StartStopBtn.Size = new System.Drawing.Size(147, 71);
            this.StartStopBtn.TabIndex = 4;
            this.StartStopBtn.Text = "Start";
            this.StartStopBtn.UseVisualStyleBackColor = true;
            this.StartStopBtn.Click += new System.EventHandler(this.StartStopBtn_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartStopBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortTxt);
            this.Controls.Add(this.HostTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cards Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HostTxt;
        private System.Windows.Forms.TextBox PortTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartStopBtn;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

