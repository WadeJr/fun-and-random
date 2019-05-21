using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLib;


namespace TwilioDB
{
    class Functions
    {

        public static DB_Lite db;

        public Functions()
        {

        }

        //Get the questions from db
        public List<string> GetQuestions()
        {
            string sql = "Select * from Questions";
            DataTable dt = db.GetTable(sql);

            List<string> list = new List<string>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Check(list, dt.Rows[i]["Task"].ToString());
            }

            return list;
            
        }

      


        public void Check(List<string> list, string task)
        {
            foreach(var item in list)
            {
                if(item == task)
                {
                    return;
                }
            }
            list.Add(task);
        }

        public List<string> GetContent(string task)
        {
            string sql = "Select * from Questions where Task='" + task +"'";
            DataTable dt = db.GetTable(sql);
            
            List<string> list = new List<string>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(dt.Rows[i]["Content"].ToString());
            }

            return list;
        }



        public void AddQuestion(string task, string content)
        {
            List<string> param = new List<string>();
            List<string> values = new List<string>();
      

            
            param.Add("Task");
            param.Add("Content");


            values.Add(task);
            values.Add(content);

            db.SqlInsert("Questions", param, values, true);
        }



        public void EditQuestion(string task, string newQuestion)
        {

            string sql = "Update Questions Set Task='" + newQuestion + "' where Task='" + task + "'";
            db.UpdateDB(sql);
        }


        public void DeleteQuestion(string task)
        {
            string sql = "Delete From Questions where Task='" + task + "'";
            db.UpdateDB(sql);
        }
     
        public void EditContent(string question, string oldContent, string content)
        {
            string sql = "Update Questions Set Task='" + question + "', Content='"+ content+ "' where Task='" + question + "' and Content='" + oldContent +"'";
            db.UpdateDB(sql);
        }
        public void DeleteContent(string task, string content)
        {
            string sql = "Delete From Questions where Task='" + task + "' and Content='" + content + "'";
            db.UpdateDB(sql);
        }

    }
}
