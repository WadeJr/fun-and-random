using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwilioDB
{
    public partial class Question : Form
    {
        Functions functions = new Functions();
        public Question()
        {
            InitializeComponent();
        }

        private void Question_Load(object sender, EventArgs e)
        {
            addBox.Checked = true;
 
            questions.DataSource = functions.GetQuestions().OrderBy(c => c).ToList();
        }

        private void addBox_CheckedChanged(object sender, EventArgs e)
        {
            if (addBox.Checked)
            {
               
                editBox.Checked = false;
                deleteBox.Checked = false;
                mainBtn.Text = "Add";
                textBox1.Visible = true;
                label1.Visible = true;
                questions.Visible = false;
                label2.Visible = false;
                label1.Text = "Question:";
                label3.Visible = true;
                content.Visible = true;
            }
        }

        private void editBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editBox.Checked)
            {
                
                addBox.Checked = false;
                deleteBox.Checked = false;
                mainBtn.Text = "Edit";
                textBox1.Visible = true;
                label1.Visible = true;
                questions.Visible = true;
                label2.Visible = true;
                label1.Text = "Change to:";
                label3.Visible = false;
                content.Visible = false;
            }
        }

        private void deleteBox_CheckedChanged(object sender, EventArgs e)
        {
            if (deleteBox.Checked)
            {
               
                addBox.Checked = false;
                editBox.Checked = false;
                mainBtn.Text = "Delete";
                textBox1.Visible = false;
                label1.Visible = false;
                questions.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                content.Visible = false;

            }
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            switch (mainBtn.Text)
            {
                case "Add":

                   functions.AddQuestion(textBox1.Text, content.Text);

                    break;
                case "Edit":

                   functions.EditQuestion(questions.SelectedValue.ToString(), textBox1.Text);
                    
                    break;
                case "Delete":

                    functions.DeleteQuestion(questions.SelectedValue.ToString());

                    break;
            }
            ((Main)this.Owner).RefreshUI();
            Close();
        }
    }
}
