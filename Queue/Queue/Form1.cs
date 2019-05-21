using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Queue
{
    public struct item
    {
        public string word { get; set; }
        public int num { get; set; }

        public item(string x, int y)
        {
            word = x;
            num = y;
        }
    };

    public partial class Form1 : Form
    {
        //Initializers
        bool pause = true;
        List<item> list = new List<item>();
        Continue @continue = new Continue();
        bool first = true;
        bool signal = true;

        ExcelFunctions excel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Go used as signal to go to next item
            Continue.go = true;

            //Mute beep
            Continue.mute = false;

            //Start listening on the Console
            CreateThread(Console);
        }

        //Add button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Add item to Console
                CreateThread(AddToQueue);
               
                //First call
                if (first)
                {
                    CreateThread(print);
                    first = false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("You must enter both text and a number.");
            }
        }

        public void print()
        {
            while (!pause && Continue.go)
            {
                try
                {
                    if (signal && list.Count > 0)
                    {
                        
                        //Decrement count by 5
                        if (list[0].num > 5)
                        {
                            string t = list[0].word;
                            int c = list[0].num - 5;

                            signal = false;
                            
                            list[0] = (new item(t, c));

                            signal = true;
                            Thread.Sleep(4000);
                            

                        }
                        //Pop front
                        else if (list[0].num == 1)
                        {
                            list.RemoveAt(0);
                            if (list.Count > 0)
                            {
                                Continue.go = false;
                                
                                @continue.ShowDialog();
                            }
                      
                           
                        }
                        //Decrement count by 1
                        else
                        {
                            string t = list[0].word;
                            int c = list[0].num - 1;

                            signal = false;
                           
                            list[0] = (new item(t, c));
                            signal = true;
                            Thread.Sleep(2000);
                           
                        }
                    }
                }
                catch (Exception)
                { }
            }
        }

        public void Console()
        {

            while (true)
            {
                try
                {
                    if (signal)
                    {
                        //Format Console output
                        string s = String.Format("{0,-6}\t{1,-13}\t\t\t{2,-10}" + System.Environment.NewLine, "Index", "Word", "Count");
                        s += String.Format("{0,-6}\t{1,-20}\t\t\t{2,-10}" + System.Environment.NewLine, "--------", "----------", "----------");
                      

                        for(int i = 0; i < list.Count; i++)
                        {
                            s += String.Format("{0,-6}\t{1,-13}\t\t\t{2,-10}" + System.Environment.NewLine, i + 1, list[i].word, list[i].num);
                        }

                        this.Invoke((MethodInvoker)delegate ()
                        {
                            console.Text = s;
                        });
                    }

                }
                catch (Exception)
                {

                }
            }
        }

        public void AddToQueue()
        {
            try
            {

                item i = new item(text.Text, Convert.ToInt32(count.Text));
                //Look for same item and increment count
                for (int l = 0; l < list.Count; l++)
                {
                    if (i.word == list[l].word)
                    {
                        int number = i.num + list[l].num;
                        list[l] = new item(list[l].word, number);
                        return;

                    }
                }
                //Add new item to list
                list.Add(i);
            }
            catch(Exception)
            {

            }
        }

        public void AddToQueue(string text, int count)
        {
            try
            {

                item i = new item(text, count);
                //Look for same item and increment count
                for (int l = 0; l < list.Count; l++)
                {
                    if (i.word == list[l].word)
                    {
                        int number = i.num + list[l].num;
                        list[l] = new item(list[l].word, number);
                        return;

                    }
                }
                //Add new item to list
                list.Add(i);
            }
            catch (Exception)
            {

            }
        }

        //Pause button
        private void button2_Click(object sender, EventArgs e)
        {
            //Resume
            if (pause)
            {
                pause = false;
                button2.Text = "Pause";
                CreateThread(print);
     
            }
            //Pause
            else
            {
                pause = true;
                button2.Text = "Resume";
            }
        }

        //Print one button
        private void button3_Click(object sender, EventArgs e)
        {
            CreateThread(printOne);
        }

        public void printOne()
        {
            try
            {
                //Decrement count by 1
                if (list.Count > 0)
                {
                    if (list[0].num > 1)
                    {
                        string t = list[0].word;
                        int c = list[0].num - 1;

                        signal = false;

                        list[0] = (new item(t, c));
                        signal = true;
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        list.RemoveAt(0);

                    }

                }
                
            }
            catch (Exception)
            {

            }
        }

        //Remove at index
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (Convert.ToInt32(index.Text) == (i + 1))
                    {
                        list.RemoveAt(i);
                        index.Text = "";
                        return;

                    }
                }
            }
            catch(Exception)
            {

            }
        }


        public delegate void function();
        public void CreateThread(function f)
        {
            Thread t = new Thread(new ThreadStart(f));
            t.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Continue.mute = true;
            else
            {
                Continue.mute = false;
            }
        }

        //Import a file and add to queue
        private void Import(string file)
        {
            
            excel = new ExcelFunctions(file);
            //Convert spreadsheet to array
            string[,] arr = excel.ReadVals();
           
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                AddToQueue(arr[i, 0], Convert.ToInt32(arr[i, 1]));
            }
            //Close Excel file
            excel.Close();
            
        }
        public void PleaseWait(Thread t)
        {
            //Display please wait while thread is alive
            while(t.IsAlive)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    pw.Visible = true;
                });
            }
            this.Invoke((MethodInvoker)delegate ()
            {
                pw.Visible = false;
            });
            //Make sure thread closes
            t.Abort();
        }
        //Import button
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //Open dialog to select file to import
                OpenFileDialog file = new OpenFileDialog();
                if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Thread t = new Thread(() => Import(file.FileName));
                    t.Start();
                    Thread t2 = new Thread(() => PleaseWait(t));
                    t2.Start();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Failed to import file.");
            }
        }
     
    }
}

