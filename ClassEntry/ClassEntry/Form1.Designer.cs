namespace ClassEntry
{
    partial class Entry
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
            this.stopResetBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.consoleTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stopResetBtn
            // 
            this.stopResetBtn.Location = new System.Drawing.Point(2489, 77);
            this.stopResetBtn.Name = "stopResetBtn";
            this.stopResetBtn.Size = new System.Drawing.Size(208, 69);
            this.stopResetBtn.TabIndex = 15;
            this.stopResetBtn.Text = "Stop";
            this.stopResetBtn.UseVisualStyleBackColor = true;
            this.stopResetBtn.Click += new System.EventHandler(this.stopResetBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1346, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Console";
            // 
            // consoleTxt
            // 
            this.consoleTxt.Location = new System.Drawing.Point(112, 263);
            this.consoleTxt.Multiline = true;
            this.consoleTxt.Name = "consoleTxt";
            this.consoleTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleTxt.Size = new System.Drawing.Size(2599, 1077);
            this.consoleTxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1414, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Url:";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(1480, 96);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(451, 31);
            this.idText.TabIndex = 10;
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(746, 96);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(451, 31);
            this.urlText.TabIndex = 9;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(2237, 77);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(208, 69);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2873, 1402);
            this.Controls.Add(this.stopResetBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.consoleTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.startBtn);
            this.Name = "Entry";
            this.Text = "Class Entry";
            this.Load += new System.EventHandler(this.Entry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stopResetBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox consoleTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Button startBtn;
    }
}

