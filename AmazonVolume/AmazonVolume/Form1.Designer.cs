namespace AmazonVolume
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.bestSellersBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableBtn = new System.Windows.Forms.Button();
            this.keywordsBtn = new System.Windows.Forms.Button();
            this.trendsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(408, 28);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(143, 65);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // volumeLbl
            // 
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.Location = new System.Drawing.Point(123, 108);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(24, 25);
            this.volumeLbl.TabIndex = 2;
            this.volumeLbl.Text = "0";
            // 
            // bestSellersBtn
            // 
            this.bestSellersBtn.Location = new System.Drawing.Point(557, 28);
            this.bestSellersBtn.Name = "bestSellersBtn";
            this.bestSellersBtn.Size = new System.Drawing.Size(143, 65);
            this.bestSellersBtn.TabIndex = 3;
            this.bestSellersBtn.Text = "Best Sellers";
            this.bestSellersBtn.UseVisualStyleBackColor = true;
            this.bestSellersBtn.Click += new System.EventHandler(this.bestSellersBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Volume:";
            // 
            // tableBtn
            // 
            this.tableBtn.Location = new System.Drawing.Point(557, 108);
            this.tableBtn.Name = "tableBtn";
            this.tableBtn.Size = new System.Drawing.Size(143, 65);
            this.tableBtn.TabIndex = 5;
            this.tableBtn.Text = "Table";
            this.tableBtn.UseVisualStyleBackColor = true;
            this.tableBtn.Click += new System.EventHandler(this.tableBtn_Click);
            // 
            // keywordsBtn
            // 
            this.keywordsBtn.Location = new System.Drawing.Point(408, 108);
            this.keywordsBtn.Name = "keywordsBtn";
            this.keywordsBtn.Size = new System.Drawing.Size(143, 65);
            this.keywordsBtn.TabIndex = 6;
            this.keywordsBtn.Text = "Keywords";
            this.keywordsBtn.UseVisualStyleBackColor = true;
            this.keywordsBtn.Click += new System.EventHandler(this.keywordsBtn_Click);
            // 
            // trendsBtn
            // 
            this.trendsBtn.Location = new System.Drawing.Point(259, 108);
            this.trendsBtn.Name = "trendsBtn";
            this.trendsBtn.Size = new System.Drawing.Size(143, 65);
            this.trendsBtn.TabIndex = 7;
            this.trendsBtn.Text = "Trends";
            this.trendsBtn.UseVisualStyleBackColor = true;
            this.trendsBtn.Click += new System.EventHandler(this.trendsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(723, 195);
            this.Controls.Add(this.trendsBtn);
            this.Controls.Add(this.keywordsBtn);
            this.Controls.Add(this.tableBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bestSellersBtn);
            this.Controls.Add(this.volumeLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Amazon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label volumeLbl;
        private System.Windows.Forms.Button bestSellersBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tableBtn;
        private System.Windows.Forms.Button keywordsBtn;
        private System.Windows.Forms.Button trendsBtn;
    }
}

