using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLib;

namespace AmazonVolume
{
    public partial class Table : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);


        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;


        DB db = new DB("Amazon");

        public Table()
        {
            InitializeComponent();
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }




        private void Table_Load(object sender, EventArgs e)
        {
            Placeholder(productTxt, "Product");
            Placeholder(priceTxt, "Price");
            Placeholder(bsrTxt, "BSR");
            Placeholder(volumeTxt, "Volume");
            Placeholder(urlTxt, "Url");
            Placeholder(asinTxt, "ASIN");

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Left,
                                      workingArea.Bottom - Size.Height);

            dataGridView1.DataSource = db.GetTable("Select * from Products");

        }

        public void Placeholder(TextBox textBox, string text)
        {
            SendMessage(textBox.Handle, 0x1501, 0, text);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            List<string> param = new List<string>()
            {
                "Products",
                "Price",
                "BSR",
                "Volume",
                "Url",
                "ASIN"
            }
            ;
            List<string> values = new List<string>()
            {
                productTxt.Text,
                priceTxt.Text,
                AddCommas(bsrTxt.Text),
                AddCommas(volumeTxt.Text),
                urlTxt.Text,
                asinTxt.Text
            };

            db.SqlInsert("Products", param, values);

            productTxt.Text = "";
            priceTxt.Text = "";
            bsrTxt.Text = "";
            volumeTxt.Text = "";
            urlTxt.Text = "";
            asinTxt.Text = "";
            productTxt.Focus();
            dataGridView1.DataSource = db.GetTable("Select * from Products");
        }



        public string AddCommas(string num)
        {
            int count = 0;
            string newNum = "", retString = "";
            for (int i = num.Length - 1; i >= 0; i--, count++)
            {
                if (count % 3 == 0 && count != 0)
                {

                    if (num[i] != ',')
                    {
                        newNum += ",";

                        count = 0;
                    }
                    else
                    {
                        count = -1;
                    }


                }


                newNum += num[i];
            }
            for (int i = newNum.Length - 1; i >= 0; i--)
            {
                retString += newNum[i];
            }
            return retString;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string product = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            db.UpdateDB("Delete from Products where CONVERT(VARCHAR, Product)='" + product + "'");

        }

        private void Table_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
        }


    }
}
