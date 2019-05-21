namespace AmazonVolume
{
    partial class Keywords
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.keyword = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(35, 55);
            this.keyword.Multiline = true;
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(218, 31);
            this.keyword.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(259, 55);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(92, 39);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(316, 603);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // toolBtn
            // 
            this.toolBtn.Location = new System.Drawing.Point(259, 12);
            this.toolBtn.Name = "toolBtn";
            this.toolBtn.Size = new System.Drawing.Size(92, 39);
            this.toolBtn.TabIndex = 4;
            this.toolBtn.Text = "Tool";
            this.toolBtn.UseVisualStyleBackColor = true;
            this.toolBtn.Click += new System.EventHandler(this.toolBtn_Click);
            // 
            // Keywords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 738);
            this.Controls.Add(this.toolBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Keywords";
            this.ShowIcon = false;
            this.Text = "Keywords";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Keywords_FormClosing);
            this.Load += new System.EventHandler(this.Keywords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button toolBtn;
    }
}