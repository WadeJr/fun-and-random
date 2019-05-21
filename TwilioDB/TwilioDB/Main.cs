using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLib;


namespace TwilioDB
{
    public partial class Main : Form
    {
        
        Functions functions = new Functions();
        
        public Main ParentForme { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
                      
        }

        private void createQuestion_Click(object sender, EventArgs e)
        {
            Question q = new Question();
            
            q.ShowDialog(this);
        }

        private void editContents_Click(object sender, EventArgs e)
        {
            Content c = new Content();
            
            c.ShowDialog(this);
        }

        private void questions_SelectedIndexChanged(object sender, EventArgs e)
        {
            console.Text = "";

            List<string> contentList = functions.GetContent(questions.SelectedValue.ToString()).OrderBy(c => c).ToList();
            int num;
            for(int i = 0; i < contentList.Count; i++)
            {
                num = i + 1;
                console.Text += num + ") " + contentList[i] + System.Environment.NewLine;
            }
        }


        public void RefreshUI()
        {
            questions.DataSource = functions.GetQuestions().OrderBy(c => c).ToList();
        }

        private void Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Functions.db = new DB_Lite(file.FileName, false);
            }
            questions.DataSource = functions.GetQuestions().OrderBy(c => c).ToList();

        }
    }
}
