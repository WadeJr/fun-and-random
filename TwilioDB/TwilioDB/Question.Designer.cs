namespace TwilioDB
{
    partial class Question
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
            this.label1 = new System.Windows.Forms.Label();
            this.mainBtn = new System.Windows.Forms.Button();
            this.addBox = new System.Windows.Forms.CheckBox();
            this.questions = new System.Windows.Forms.ComboBox();
            this.editBox = new System.Windows.Forms.CheckBox();
            this.deleteBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question:";
            // 
            // mainBtn
            // 
            this.mainBtn.Location = new System.Drawing.Point(207, 279);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(240, 60);
            this.mainBtn.TabIndex = 2;
            this.mainBtn.Text = "Add";
            this.mainBtn.UseVisualStyleBackColor = true;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // addBox
            // 
            this.addBox.AutoSize = true;
            this.addBox.Location = new System.Drawing.Point(511, 74);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(82, 29);
            this.addBox.TabIndex = 3;
            this.addBox.Text = "Add";
            this.addBox.UseVisualStyleBackColor = true;
            this.addBox.CheckedChanged += new System.EventHandler(this.addBox_CheckedChanged);
            // 
            // questions
            // 
            this.questions.FormattingEnabled = true;
            this.questions.Location = new System.Drawing.Point(184, 34);
            this.questions.Name = "questions";
            this.questions.Size = new System.Drawing.Size(276, 33);
            this.questions.TabIndex = 4;
            this.questions.Visible = false;
            // 
            // editBox
            // 
            this.editBox.AutoSize = true;
            this.editBox.Location = new System.Drawing.Point(511, 109);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(81, 29);
            this.editBox.TabIndex = 5;
            this.editBox.Text = "Edit";
            this.editBox.UseVisualStyleBackColor = true;
            this.editBox.CheckedChanged += new System.EventHandler(this.editBox_CheckedChanged);
            // 
            // deleteBox
            // 
            this.deleteBox.AutoSize = true;
            this.deleteBox.Location = new System.Drawing.Point(511, 144);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(106, 29);
            this.deleteBox.TabIndex = 6;
            this.deleteBox.Text = "Delete";
            this.deleteBox.UseVisualStyleBackColor = true;
            this.deleteBox.CheckedChanged += new System.EventHandler(this.deleteBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Question:";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 31);
            this.textBox1.TabIndex = 8;
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(184, 161);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(276, 73);
            this.content.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Content:";
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.content);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.questions);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.mainBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Question";
            this.ShowIcon = false;
            this.Text = "Question";
            this.Load += new System.EventHandler(this.Question_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.CheckBox addBox;
        private System.Windows.Forms.ComboBox questions;
        private System.Windows.Forms.CheckBox editBox;
        private System.Windows.Forms.CheckBox deleteBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Label label3;
    }
}