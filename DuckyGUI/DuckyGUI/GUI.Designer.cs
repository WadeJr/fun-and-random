namespace DuckyGUI
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.LineNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SaveAsBtn = new System.Windows.Forms.Button();
            this.CommandsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentName = new System.Windows.Forms.Label();
            this.DecodeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LineNumberTextBox
            // 
            this.LineNumberTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineNumberTextBox.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.LineNumberTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LineNumberTextBox.Location = new System.Drawing.Point(0, 0);
            this.LineNumberTextBox.Name = "LineNumberTextBox";
            this.LineNumberTextBox.ReadOnly = true;
            this.LineNumberTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LineNumberTextBox.Size = new System.Drawing.Size(81, 636);
            this.LineNumberTextBox.TabIndex = 1;
            this.LineNumberTextBox.Text = "";
            this.LineNumberTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LineNumberTextBox_MouseDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(74, -3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(848, 645);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
            this.richTextBox1.FontChanged += new System.EventHandler(this.richTextBox1_FontChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ImportBtn
            // 
            this.ImportBtn.Location = new System.Drawing.Point(996, 77);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(142, 52);
            this.ImportBtn.TabIndex = 3;
            this.ImportBtn.Text = "Load";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.Location = new System.Drawing.Point(996, 135);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(142, 52);
            this.ExportBtn.TabIndex = 4;
            this.ExportBtn.Text = "Export";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(931, 572);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(142, 52);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SaveAsBtn
            // 
            this.SaveAsBtn.Location = new System.Drawing.Point(1079, 572);
            this.SaveAsBtn.Name = "SaveAsBtn";
            this.SaveAsBtn.Size = new System.Drawing.Size(142, 52);
            this.SaveAsBtn.TabIndex = 6;
            this.SaveAsBtn.Text = "Save As ...";
            this.SaveAsBtn.UseVisualStyleBackColor = true;
            this.SaveAsBtn.Click += new System.EventHandler(this.SaveAsBtn_Click);
            // 
            // CommandsBtn
            // 
            this.CommandsBtn.Location = new System.Drawing.Point(996, 312);
            this.CommandsBtn.Name = "CommandsBtn";
            this.CommandsBtn.Size = new System.Drawing.Size(142, 52);
            this.CommandsBtn.TabIndex = 7;
            this.CommandsBtn.Text = "Commands";
            this.CommandsBtn.UseVisualStyleBackColor = true;
            this.CommandsBtn.Click += new System.EventHandler(this.CommandsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(928, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current File: ";
            // 
            // currentName
            // 
            this.currentName.AutoSize = true;
            this.currentName.Location = new System.Drawing.Point(1054, 9);
            this.currentName.Name = "currentName";
            this.currentName.Size = new System.Drawing.Size(54, 25);
            this.currentName.TabIndex = 9;
            this.currentName.Text = "New";
            // 
            // DecodeBtn
            // 
            this.DecodeBtn.Location = new System.Drawing.Point(996, 193);
            this.DecodeBtn.Name = "DecodeBtn";
            this.DecodeBtn.Size = new System.Drawing.Size(142, 52);
            this.DecodeBtn.TabIndex = 10;
            this.DecodeBtn.Text = "Decode";
            this.DecodeBtn.UseVisualStyleBackColor = true;
            this.DecodeBtn.Visible = false;
            this.DecodeBtn.Click += new System.EventHandler(this.DecodeBtn_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1224, 636);
            this.Controls.Add(this.DecodeBtn);
            this.Controls.Add(this.currentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommandsBtn);
            this.Controls.Add(this.SaveAsBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ExportBtn);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.LineNumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DuckyScript";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.Resize += new System.EventHandler(this.GUI_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox LineNumberTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button SaveAsBtn;
        private System.Windows.Forms.Button CommandsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentName;
        private System.Windows.Forms.Button DecodeBtn;
    }
}

