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
    public partial class Content : Form
    {
        Functions functions = new Functions();
        public Content()
        {
            InitializeComponent();
        }

        private void Content_Load(object sender, EventArgs e)
        {
            questions.DataSource = functions.GetQuestions().OrderBy(c => c).ToList();

            addBox.Checked = true;
        }


        private void addBox_CheckedChanged(object sender, EventArgs e)
        {
            if (addBox.Checked)
            {
                
                editBox.Checked = false;
                deleteBox.Checked = false;
                label1.Visible = true;
                contentTxt.Visible = true;
                mainBtn.Text = "Add";
                label1.Text = "Content:";

            }
        }

        private void editBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editBox.Checked)
            {
                addBox.Checked = false;
                deleteBox.Checked = false;
                mainBtn.Text = "Edit";
                label1.Visible = true;
                contentTxt.Visible = true;
                label1.Text = "Change to:";
            }
        }

        private void deleteBox_CheckedChanged(object sender, EventArgs e)
        {
            if (deleteBox.Checked)
            {
               
                addBox.Checked = false;
                editBox.Checked = false;
                mainBtn.Text = "Delete";
                contentTxt.Visible = false;
                label1.Visible = false;
              

            }
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            switch (mainBtn.Text)
            {
                case "Add":

                    functions.AddQuestion(questions.SelectedValue.ToString(), contentTxt.Text);

                    break;
                case "Edit":

                    functions.EditContent(questions.SelectedValue.ToString(), contentList.SelectedValue.ToString(), contentTxt.Text);

                    break;
                case "Delete":

                    functions.DeleteContent(questions.SelectedValue.ToString(), contentList.SelectedValue.ToString());

                    break;
            }
            ((Main)this.Owner).RefreshUI();
            Close();
        }

        private void questions_SelectedIndexChanged(object sender, EventArgs e)
        {
            contentList.DataSource = functions.GetContent(questions.SelectedValue.ToString()).OrderBy(c => c).ToList();
        }
    }
}
