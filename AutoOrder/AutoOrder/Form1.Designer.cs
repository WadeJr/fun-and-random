namespace AutoOrder
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
            this.wingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wingBtn
            // 
            this.wingBtn.Location = new System.Drawing.Point(316, 127);
            this.wingBtn.Name = "wingBtn";
            this.wingBtn.Size = new System.Drawing.Size(134, 67);
            this.wingBtn.TabIndex = 0;
            this.wingBtn.Text = "Wing Stop";
            this.wingBtn.UseVisualStyleBackColor = true;
            this.wingBtn.Click += new System.EventHandler(this.wingBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 358);
            this.Controls.Add(this.wingBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Auto Order";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wingBtn;
    }
}

