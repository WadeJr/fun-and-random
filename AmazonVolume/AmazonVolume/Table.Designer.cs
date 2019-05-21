namespace AmazonVolume
{
    partial class Table
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
            this.productTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.bsrTxt = new System.Windows.Forms.TextBox();
            this.volumeTxt = new System.Windows.Forms.TextBox();
            this.urlTxt = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.asinTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // productTxt
            // 
            this.productTxt.Location = new System.Drawing.Point(25, 24);
            this.productTxt.Name = "productTxt";
            this.productTxt.Size = new System.Drawing.Size(173, 31);
            this.productTxt.TabIndex = 0;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(214, 24);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(109, 31);
            this.priceTxt.TabIndex = 1;
            // 
            // bsrTxt
            // 
            this.bsrTxt.Location = new System.Drawing.Point(329, 24);
            this.bsrTxt.Name = "bsrTxt";
            this.bsrTxt.Size = new System.Drawing.Size(109, 31);
            this.bsrTxt.TabIndex = 2;
            // 
            // volumeTxt
            // 
            this.volumeTxt.Location = new System.Drawing.Point(444, 24);
            this.volumeTxt.Name = "volumeTxt";
            this.volumeTxt.Size = new System.Drawing.Size(120, 31);
            this.volumeTxt.TabIndex = 3;
            // 
            // urlTxt
            // 
            this.urlTxt.Location = new System.Drawing.Point(570, 24);
            this.urlTxt.Name = "urlTxt";
            this.urlTxt.Size = new System.Drawing.Size(149, 31);
            this.urlTxt.TabIndex = 4;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(853, 15);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(109, 49);
            this.createBtn.TabIndex = 5;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(937, 324);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // asinTxt
            // 
            this.asinTxt.Location = new System.Drawing.Point(727, 24);
            this.asinTxt.Name = "asinTxt";
            this.asinTxt.Size = new System.Drawing.Size(120, 31);
            this.asinTxt.TabIndex = 7;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 403);
            this.Controls.Add(this.asinTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.urlTxt);
            this.Controls.Add(this.volumeTxt);
            this.Controls.Add(this.bsrTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.productTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Table";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Table_FormClosing);
            this.Load += new System.EventHandler(this.Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox bsrTxt;
        private System.Windows.Forms.TextBox volumeTxt;
        private System.Windows.Forms.TextBox urlTxt;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox asinTxt;
    }
}