using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;

namespace Queue
{
    class ExcelFunctions
    {
        string path = "";
        _Application excel = new Application();
        Workbook wb;
        Worksheet ws;

        public ExcelFunctions(string path)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path, null ,true);
            ws = wb.Worksheets[1];
        }
        public int GetWidth()
        {
            int i = 1;

            while (ws.Cells[1, i].Value2 != null)
            {
                i++;
            }

            return i;
        }

        public int GetHeight()
        {
            int i = 1;

            while (ws.Cells[i, 1].Value2 != null)
            {
                i++;
            }

            return i;
        }
        
        public void Close()
        {
            wb.Close();
        }

        public string [,] ReadVals()
        {
            int height = GetHeight();
            Range range = (Range)ws.Range[ws.Cells[1, 1], ws.Cells[height, 2]];
            object[,] holder = range.Value2;
            string[,] returnstring = new string[height - 1, 2];
            for(int i = 1; i <= height - 1; i++)
            {
               for(int j = 1; j <= 2; j++)
                {
                    returnstring[i - 1, j - 1] = holder[i, j].ToString();
                }
            }
            return returnstring;
        }
        


    }
}
