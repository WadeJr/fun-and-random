namespace Queue
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
            this.text = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.console = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.index = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(44, 99);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(150, 31);
            this.text.TabIndex = 0;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(44, 174);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(150, 31);
            this.count.TabIndex = 1;
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(381, 58);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(621, 343);
            this.console.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 58);
            this.button3.TabIndex = 7;
            this.button3.Text = "Print one";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(381, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Remove Index";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(549, 440);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(124, 31);
            this.index.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Remove index:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(44, 442);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 29);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Mute";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(44, 523);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 40);
            this.button5.TabIndex = 12;
            this.button5.Text = "Import";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Location = new System.Drawing.Point(201, 531);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(146, 25);
            this.pw.TabIndex = 13;
            this.pw.Text = "Please wait ...";
            this.pw.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 646);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.index);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.console);
            this.Controls.Add(this.count);
            this.Controls.Add(this.text);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label pw;
    }
}

