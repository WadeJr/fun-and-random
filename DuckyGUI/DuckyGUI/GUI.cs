using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckyGUI
{
    public partial class GUI : Form
    {
        //Has the text been saved
        public bool newText = false;

        //Has the file been saved or load
        public bool inMemory = false;


        public string CurrentFile = "";

        public string CurrentText = "";

        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = richTextBox1.Font;
            richTextBox1.Select();
            AddLineNumbers();
        }


        #region  LineNumbers
        public int getWidth()
        {
            int w = 25;
            // get total lines of richTextBox1    
            int line = richTextBox1.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)richTextBox1.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)richTextBox1.Font.Size;
            }
            else
            {
                w = 50 + (int)richTextBox1.Font.Size;
            }

            return w;
        }

        public void AddLineNumbers()
        {
            // create & set Point pt to (0,0)    
            Point pt = new Point(0, 0);
            // get First Index & First Line from richTextBox1    
            int First_Index = richTextBox1.GetCharIndexFromPosition(pt);
            int First_Line = richTextBox1.GetLineFromCharIndex(First_Index);
            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively    
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            // get Last Index & Last Line from richTextBox1    
            int Last_Index = richTextBox1.GetCharIndexFromPosition(pt);
            int Last_Line = richTextBox1.GetLineFromCharIndex(Last_Index);
            // set Center alignment to LineNumberTextBox    
            LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Center;
            // set LineNumberTextBox text to null & width to getWidth() function value    
            LineNumberTextBox.Text = "";
            LineNumberTextBox.Width = getWidth();
            // now add each line number to LineNumberTextBox upto last line    
            for (int i = First_Line; i <= Last_Line + 2; i++)
            {
                LineNumberTextBox.Text += i + 1 + "\n";
            }
        }


        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = richTextBox1.GetPositionFromCharIndex(richTextBox1.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            LineNumberTextBox.Text = "";
            AddLineNumbers();
            LineNumberTextBox.Invalidate();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            CreateThread(newCheck);
            newText = true;
            if (richTextBox1.Text == "")
            {
                AddLineNumbers();
            }
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = richTextBox1.Font;
            richTextBox1.Select();
            AddLineNumbers();
        }

        private void LineNumberTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Select();
            LineNumberTextBox.DeselectAll();
        }

        private void GUI_Resize(object sender, EventArgs e)
        {
            AddLineNumbers();
        }
        #endregion



        #region Buttons

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            Save(CurrentFile);
            Export();
            FocusText();
        }

        private void CommandsBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/hak5darren/USB-Rubber-Ducky/wiki/Duckyscript");
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Save(CurrentFile);
            FocusText();
        }

        private void SaveAsBtn_Click(object sender, EventArgs e)
        {
            SaveAs();
            FocusText();
        }

        private void DecodeBtn_Click(object sender, EventArgs e)
        {
           /*
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = @"C:/Users/wade2/Desktop/Hacking/fun/DuckyGUI/Files/Duck-Decoder-master/ | ./inject.sh";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;

            p.StartInfo = info;
            p.Start();

            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("$cd /");
                   // sw.WriteLine("cd mnt/c/Users/wade2/Desktop/Hacking/fun/DuckyGUI/Files/Duck-Decoder-master");
                  //  sw.WriteLine("python DuckDecoder.py display D:/inject.bin > C:/Users/wade2/Desktop/Hacking/fun/DuckyGUI/Files/inject.txt");

                }
            }
            if (SaveCheck(richTextBox1.Text, CurrentText))
            {
                DialogResult result = MessageBox.Show("Do you want to save changes first?", "Yes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (CurrentFile == "")
                    {
                        SaveAs();
                    }
                    else
                    {
                        Save(CurrentFile);
                    }

                }

            }
            try
            {
                string file = "C:/Users/wade2/Desktop/Hacking/fun/DuckyGUI/Files/inject.txt";

                //Add contents of file to textbox
                richTextBox1.Text = CurrentText = File.ReadAllText(file);
                inMemory = true;
                CurrentFile = file;
                currentName.Text = stripDir(file);


            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Decode file.");
            }

            CurrentText = richTextBox1.Text;
            newText = false;
            FocusText();
            */
        }


        #endregion

        //Compare text
        private bool SaveCheck(string text, string text2)
        {
            if (string.Compare(text, text2) == 0)
            {
                return false;
            }
            return true;
        }

        //New thread function
        public delegate void function();
        public void CreateThread(function f)
        {
            Thread t = new Thread(new ThreadStart(f));
            t.Start();
        }

        public void SaveAs()
        {
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files|*.txt";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.  
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();

                fs.Close();

                CurrentFile = saveFileDialog1.FileName;
                currentName.Text = stripDir(saveFileDialog1.FileName);
                inMemory = true;
                newText = false;
                CurrentText = richTextBox1.Text;

            }

        }

        public void Import()
        {
            if (SaveCheck(richTextBox1.Text, CurrentText))
            {
                DialogResult result = MessageBox.Show("Do you want to save changes first?", "Yes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (CurrentFile == "")
                    {
                        SaveAs();
                    }
                    else
                    {
                        Save(CurrentFile);
                    }

                }

            }
            try
            {

                //Open dialog to select file to import
                OpenFileDialog file = new OpenFileDialog();

                if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Add contents of file to textbox
                    richTextBox1.Text = CurrentText = File.ReadAllText(file.FileName);
                    inMemory = true;
                    CurrentFile = file.FileName;
                    currentName.Text = stripDir(file.FileName);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to import file.");
            }

            CurrentText = richTextBox1.Text;
            newText = false;
            FocusText();
        }

        public void Save(string path)
        {
            // This text is added only once to the file.
            if (File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(richTextBox1.Text);
                }
                newText = false;
                CurrentText = richTextBox1.Text;
                CreateThread(newCheck);
            }
            else
            {
                SaveAs();
            }
        }

        //Check if new text has been written
        public void newCheck()
        {
            string text = "";
            this.Invoke((MethodInvoker)delegate ()
            {
                text = richTextBox1.Text;
            });

            if (string.Compare(text, CurrentText) == 0)
            {
                if (currentName.Text[currentName.Text.Length - 1] == '*')
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        currentName.Text = currentName.Text.Substring(0, currentName.Text.Length - 1);
                    });
                }
            }
            else
            {
                if (currentName.Text[currentName.Text.Length - 1] != '*')
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        currentName.Text += "*";
                    });
                }
            }
        }

        public void Export()
        {
            //C: \Users\wade2\Desktop\Hacking\Fun\DuckyGUI\Files

            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "powershell.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;

            p.StartInfo = info;
            p.Start();

            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("cd /");
                    sw.WriteLine("cd Users/wade2/Desktop/Hacking/fun/DuckyGUI/Files");
                    sw.WriteLine("java -jar duckencoder.jar -i " + CurrentFile);
                    sw.WriteLine("mv D:/inject.bin C:/Users/wade2/Desktop/Hacking/Fun/DuckyGUI/PreviousBin/inject_"
                        + injectDate() + ".bin");
                    sw.WriteLine("mv C:/Users/wade2/Desktop/Hacking/Fun/DuckyGUI/Files/inject.bin D:/inject.bin");



                }
            }
        }


        public string stripDir(string file)
        {
            return file.Substring(50);
        }

        public void FocusText()
        {
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.SelectionLength = 0;
        }


        public string injectDate()
        {
            string date = File.GetLastWriteTime(@"D:/inject.bin").ToShortDateString();
            string newDate = "";
            for (int i = 0; i < date.Length; i++)
            {
                if (date[i] == '/')
                {
                    newDate += '_';
                }
                else
                {
                    newDate += date[i];
                }

            }
            return newDate;
        }


    }
}





