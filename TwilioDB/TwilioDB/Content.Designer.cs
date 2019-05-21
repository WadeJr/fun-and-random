namespace TwilioDB
{
    partial class Content
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
            this.contentTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBox = new System.Windows.Forms.CheckBox();
            this.editBox = new System.Windows.Forms.CheckBox();
            this.questions = new System.Windows.Forms.ComboBox();
            this.addBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainBtn = new System.Windows.Forms.Button();
            this.contentList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contentTxt
            // 
            this.contentTxt.Location = new System.Drawing.Point(184, 144);
            this.contentTxt.Multiline = true;
            this.contentTxt.Name = "contentTxt";
            this.contentTxt.Size = new System.Drawing.Size(276, 69);
            this.contentTxt.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Question:";
            // 
            // deleteBox
            // 
            this.deleteBox.AutoSize = true;
            this.deleteBox.Location = new System.Drawing.Point(530, 144);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(106, 29);
            this.deleteBox.TabIndex = 14;
            this.deleteBox.Text = "Delete";
            this.deleteBox.UseVisualStyleBackColor = true;
            this.deleteBox.CheckedChanged += new System.EventHandler(this.deleteBox_CheckedChanged);
            // 
            // editBox
            // 
            this.editBox.AutoSize = true;
            this.editBox.Location = new System.Drawing.Point(530, 109);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(81, 29);
            this.editBox.TabIndex = 13;
            this.editBox.Text = "Edit";
            this.editBox.UseVisualStyleBackColor = true;
            this.editBox.CheckedChanged += new System.EventHandler(this.editBox_CheckedChanged);
            // 
            // questions
            // 
            this.questions.FormattingEnabled = true;
            this.questions.Location = new System.Drawing.Point(184, 36);
            this.questions.Name = "questions";
            this.questions.Size = new System.Drawing.Size(276, 33);
            this.questions.TabIndex = 12;
            this.questions.SelectedIndexChanged += new System.EventHandler(this.questions_SelectedIndexChanged);
            // 
            // addBox
            // 
            this.addBox.AutoSize = true;
            this.addBox.Location = new System.Drawing.Point(530, 74);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(82, 29);
            this.addBox.TabIndex = 11;
            this.addBox.Text = "Add";
            this.addBox.UseVisualStyleBackColor = true;
            this.addBox.CheckedChanged += new System.EventHandler(this.addBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Content:";
            // 
            // mainBtn
            // 
            this.mainBtn.Location = new System.Drawing.Point(210, 240);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(240, 60);
            this.mainBtn.TabIndex = 10;
            this.mainBtn.Text = "Add";
            this.mainBtn.UseVisualStyleBackColor = true;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // contentList
            // 
            this.contentList.FormattingEnabled = true;
            this.contentList.Location = new System.Drawing.Point(184, 95);
            this.contentList.Name = "contentList";
            this.contentList.Size = new System.Drawing.Size(276, 33);
            this.contentList.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Content:";
            // 
            // Content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contentList);
            this.Controls.Add(this.contentTxt);
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
            this.Name = "Content";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Content";
            this.Load += new System.EventHandler(this.Content_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contentTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox deleteBox;
        private System.Windows.Forms.CheckBox editBox;
        private System.Windows.Forms.ComboBox questions;
        private System.Windows.Forms.CheckBox addBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.ComboBox contentList;
        private System.Windows.Forms.Label label3;
    }
}