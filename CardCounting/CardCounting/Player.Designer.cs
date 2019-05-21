namespace CardCounting
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.Player1 = new System.Windows.Forms.Button();
            this.Player2 = new System.Windows.Forms.Button();
            this.Player3 = new System.Windows.Forms.Button();
            this.Player4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.Location = new System.Drawing.Point(357, 155);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(100, 50);
            this.Player1.TabIndex = 0;
            this.Player1.Text = "Player1";
            this.Player1.UseVisualStyleBackColor = true;
            this.Player1.Visible = false;
            this.Player1.Click += new System.EventHandler(this.Player1_Click);
            // 
            // Player2
            // 
            this.Player2.Location = new System.Drawing.Point(357, 211);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(100, 50);
            this.Player2.TabIndex = 1;
            this.Player2.Text = "Player2";
            this.Player2.UseVisualStyleBackColor = true;
            this.Player2.Visible = false;
            this.Player2.Click += new System.EventHandler(this.Player2_Click);
            // 
            // Player3
            // 
            this.Player3.Location = new System.Drawing.Point(357, 267);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(100, 50);
            this.Player3.TabIndex = 2;
            this.Player3.Text = "Player3";
            this.Player3.UseVisualStyleBackColor = true;
            this.Player3.Visible = false;
            this.Player3.Click += new System.EventHandler(this.Player3_Click);
            // 
            // Player4
            // 
            this.Player4.Location = new System.Drawing.Point(357, 323);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(100, 50);
            this.Player4.TabIndex = 3;
            this.Player4.Text = "Player4";
            this.Player4.UseVisualStyleBackColor = true;
            this.Player4.Visible = false;
            this.Player4.Click += new System.EventHandler(this.Player4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 31);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chips Amount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Player_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Player1;
        private System.Windows.Forms.Button Player2;
        private System.Windows.Forms.Button Player3;
        private System.Windows.Forms.Button Player4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}