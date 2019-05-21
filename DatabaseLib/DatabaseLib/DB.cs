using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using Dapper;


namespace DatabaseLib
{
    public class DB
    {
        //Example strings for reference
        public const string _UpdateDB_Example = "UPDATE Table_Name Set TEXT='texter', LENGTH='1.214' where NUMBER='789'";
        public const string _GetTable_Example = "Select NUMBER FROM Table_Name Where NUMBER = 5464";
        public const string _SqlInsert_Example = "Insert paramValues w/o @";


        private SqlConnection connection;


        //Init database
        public DB(string dbName, string dataSource = null, string user = null, string password = null, bool security = true)
        {

            string constr = "";

            //Catalog
            if ((user == null || password == null) && security == true && dataSource == null)
            {
                constr = @"Data Source=WADES-WORKSPACE\SQLEXPRESS; Initial Catalog=" + dbName + "; Integrated Security=true";
            }
            //Datasource and dbName
            else if ((user == null || password == null) && security == true && dataSource != null)
            {
                constr = @"Data Source=" + dataSource + "; Initial Catalog=" + dbName + "; Integrated Security=true";
            }
            //Security and dbName
            else if ((user == null || password == null) && security == false && dataSource == null)
            {
                constr = @"Data Source=WADES-WORKSPACE\SQLEXPRESS; Initial Catalog=" + dbName + "; Integrated Security=false";
            }
            //Datasource, security, and dbName
            else if ((user == null || password == null) && security == false && dataSource != null)
            {
                constr = @"Data Source=" + dataSource + "; Initial Catalog=" + dbName + "; Integrated Security=false";
            }
            //User & Pass and dbName
            else if (user != null && password != null && security == true && dataSource == null)
            {
                constr = @"Data Source=WADES-WORKSPACE\SQLEXPRESS; Initial Catalog=" + dbName + "; User id =" + user + "; Password =" + password + "; Integrated Security=true";
            }
            //User & Pass, datasource, and dbName
            else if (user != null && password != null && security == true && dataSource != null)
            {
                constr = @"Data Source=" + dataSource + "; Initial Catalog=" + dbName + "; User id =" + user + "; Password =" + password + "; Integrated Security=true";
            }
            //User & Pass, security, and dbName
            else if (user != null && password != null && security == false && dataSource == null)
            {
                constr = @"Data Source=WADES-WORKSPACE\SQLEXPRESS; Initial Catalog=" + dbName + "; User id =" + user + "; Password =" + password + "; Integrated Security=false";
            }
            //User & Pass, datasource, security, and dbName
            else if (user != null && password != null && security == false && dataSource != null)
            {
                constr = @"Data Source=" + dataSource + "; Initial Catalog=" + dbName + "; User id =" + user + "; Password =" + password + "; Integrated Security=false";
            }

            connection = new SqlConnection(constr);
            connection.Open();

        }



        //Update database
        public void UpdateDB(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
        }

        //Get table from database
        public DataTable GetTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        //Insert into database
        public void SqlInsert(string tableName, List<string> tableParams, List<string> paramValues, bool intsPresent = false)
        {
            string sql = ListToSql(tableParams, tableName);
            SqlCommand cmd = new SqlCommand(sql, connection);

            //If numbers don't equal do nothing
            if (tableParams.Count != paramValues.Count)
            {
                return;
            }
            //If ints are included in string
            if (intsPresent)
            {
                int result = 0;
                for (int i = 0; i < tableParams.Count; i++)
                {
                    //If an int convert to it
                    if (int.TryParse(paramValues[i], out result))
                    {
                        cmd.Parameters.AddWithValue("@" + tableParams[i], result);
                    }
                    //Not an int
                    else
                    {
                        cmd.Parameters.AddWithValue("@" + tableParams[i], paramValues[i]);
                    }
                }
            }
            //No ints present
            else
            {
                for (int i = 0; i < tableParams.Count; i++)
                {
                    cmd.Parameters.AddWithValue("@" + tableParams[i], paramValues[i]);
                }
            }

            cmd.ExecuteNonQuery();
        }

        //Convert list to sql for insert
        private string ListToSql(List<string> list, string tableName)
        {
            string sql = "INSERT INTO " + tableName + " VALUES (";
            for (int i = 0; i < list.Count - 1; i++)
            {
                sql += "@" + list[i] + ", ";
            }
            if (list.Count > 0)
            {
                sql += "@" + list[list.Count - 1] + ")";
            }
            else
            {
                return null;
            }

            return sql;
        }

        public void Close()
        {
            connection.Close();
        }
    }

    public class DB_Lite
    {

        
        private SQLiteConnection connection;


        public DB_Lite(string dataSource, bool saveToMemory)
        {

            string constr = "";
            if (saveToMemory)
            {
                //constr = @"Data Source=" + dataSource + "; Version=3; New=True;";
                constr = @"Data Source=:memory:; Version=3; New=True";
            }
            else
            {
                constr = @"Data Source=" + dataSource + "; Version=3;";
            }

            connection = new SQLiteConnection(constr);
            connection.Open();
        }

        public void CreateTable(string sql)
        {

            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
        }

        public void DeleteFromDB(string sql)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
        }


        //Update database
        public void UpdateDB(string sql)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
        }

        //Get table from database
        public DataTable GetTable(string sql)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        //Insert into database
        public void SqlInsert(string tableName, List<string> tableParams, List<string> paramValues, bool intsPresent = false)
        {
            string sql = ListToSql(tableParams, tableName);
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);

            //If numbers don't equal do nothing
            if (tableParams.Count != paramValues.Count)
            {
                return;
            }
            //If ints are included in string
            if (intsPresent)
            {
                int result = 0;
                for (int i = 0; i < tableParams.Count; i++)
                {
                    //If an int convert to it
                    if (int.TryParse(paramValues[i], out result))
                    {
                        cmd.Parameters.AddWithValue("@" + tableParams[i], result);
                    }
                    //Not an int
                    else
                    {
                        cmd.Parameters.AddWithValue("@" + tableParams[i], paramValues[i]);
                    }
                }
            }
            //No ints present
            else
            {
                for (int i = 0; i < tableParams.Count; i++)
                {
                    cmd.Parameters.AddWithValue("@" + tableParams[i], paramValues[i]);
                }
            }

            cmd.ExecuteNonQuery();
        }

        //Convert list to sql for insert
        private string ListToSql(List<string> list, string tableName)
        {
            string sql = "INSERT INTO " + tableName + " VALUES (";
            for (int i = 0; i < list.Count - 1; i++)
            {
                sql += "@" + list[i] + ", ";
            }
            if (list.Count > 0)
            {
                sql += "@" + list[list.Count - 1] + ")";
            }
            else
            {
                return null;
            }

            return sql;
        }

        public void Close()
        {
            connection.Close();
        }
    }

}
