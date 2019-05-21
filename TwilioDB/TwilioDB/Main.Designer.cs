namespace TwilioDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.questions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createQuestion = new System.Windows.Forms.Button();
            this.editContents = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questions
            // 
            this.questions.FormattingEnabled = true;
            this.questions.Location = new System.Drawing.Point(275, 47);
            this.questions.Name = "questions";
            this.questions.Size = new System.Drawing.Size(285, 33);
            this.questions.TabIndex = 0;
            this.questions.SelectedIndexChanged += new System.EventHandler(this.questions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Questions";
            // 
            // createQuestion
            // 
            this.createQuestion.Location = new System.Drawing.Point(597, 31);
            this.createQuestion.Name = "createQuestion";
            this.createQuestion.Size = new System.Drawing.Size(221, 92);
            this.createQuestion.TabIndex = 2;
            this.createQuestion.Text = "Create / Edit Question";
            this.createQuestion.UseVisualStyleBackColor = true;
            this.createQuestion.Click += new System.EventHandler(this.createQuestion_Click);
            // 
            // editContents
            // 
            this.editContents.Location = new System.Drawing.Point(837, 31);
            this.editContents.Name = "editContents";
            this.editContents.Size = new System.Drawing.Size(221, 92);
            this.editContents.TabIndex = 3;
            this.editContents.Text = "Create / Edit Contents of Question";
            this.editContents.UseVisualStyleBackColor = true;
            this.editContents.Click += new System.EventHandler(this.editContents_Click);
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(43, 214);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(1086, 617);
            this.console.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(476, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Content of Question";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "DB Path ...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Path_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1160, 891);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.console);
            this.Controls.Add(this.editContents);
            this.Controls.Add(this.createQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twilio Database";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox questions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createQuestion;
        private System.Windows.Forms.Button editContents;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

