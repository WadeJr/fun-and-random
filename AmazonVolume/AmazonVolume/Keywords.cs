using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLib;

namespace AmazonVolume
{
    public partial class Keywords : Form
    {
        public Keywords()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);


        DB db = new DB("Amazon");


        private void Keywords_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height - 136);

            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            Placeholder(keyword, "Keyword");


            string sql = "Select Product from Products";
            DataTable dt = db.GetTable(sql);

            comboBox1.DataSource = Dt2List(dt, "Product");



        }

        private void Keywords_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {


            string product = comboBox1.SelectedValue.ToString();

            AddKeyword(keyword.Text);


            string sql = "Select Keyword from Keywords where CONVERT(VARCHAR, Product)='" + product + "' Order by Priority ASC";
            DataTable dt = db.GetTable(sql);


            dataGridView1.DataSource = dt;

            keyword.Text = "";
        }

        public void Placeholder(TextBox textBox, string text)
        {
            SendMessage(textBox.Handle, 0x1501, 0, text);
        }


        public List<string> Dt2List(DataTable dt, string rowName)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(dt.Rows[i][rowName].ToString());
            }
            return list;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string product = comboBox1.SelectedValue.ToString();
            string sql = "Select Keyword from Keywords where CONVERT(VARCHAR, Product)='" + product + "' Order by Priority ASC";
            DataTable dt = db.GetTable(sql);


            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 115;

        }

        public void AddKeyword(string keywords)
        {
            string keyword = "";
            List<string> list = new List<string>();
            bool firstLetter = true;

            foreach (var letter in keywords)
            {

                if (letter == ' ' || letter == '\n')
                {
                    if (keyword != "")
                    {
                        list.Add(keyword);
                    }
                    keyword = "";
                    firstLetter = true;
                }
                else if(letter == ',')
                {

                }
                else if (firstLetter)
                {
                    keyword += letter.ToString().ToUpper();
                    firstLetter = false;
                }
                else
                {
                    keyword += letter;
                }
            }
            if (keyword != "")
            {
                list.Add(keyword);
            }

            string sql, product, count;
            int num = 0;
            List<string> param = new List<string>()
            {
                "Product",
                "Keyword",
                "Priority"
            };

            foreach (var word in list)
            {
                sql = "Select Keyword from Keywords where CONVERT(VARCHAR, Keyword)='" + word.Trim() + "'";
                num = db.GetTable(sql).Rows.Count;

                if (num == 0)
                {
                    product = comboBox1.SelectedValue.ToString();
                    sql = "Select Max(Priority) from Keywords where CONVERT(VARCHAR, Product)='" + product + "'";
                    count = Convert.ToString(Convert.ToInt32(db.GetTable(sql).Rows[0][0]) + 1);
                   
                    List<string> values = new List<string>()
                    {
                        comboBox1.SelectedValue.ToString(),
                        word,
                        count
                    };

                    try
                    {
                        db.SqlInsert("Keywords", param, values, true);
                    }
                    catch
                    {

                    }

                }

            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string keywords = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            db.UpdateDB("Delete from Keywords where CONVERT(VARCHAR, keyword)='" + keywords + "'");
        }

        private void toolBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://keywordtool.io/amazon/");
        }
    }
}
