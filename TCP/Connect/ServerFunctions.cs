using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP
{
    class ServerFunctions
    {

        public ServerFunctions()
        {

        }

        public void FunctionChecks(TextBox status)
        {
            // Get the last line
            string lastLine = "";
            string[] Lines = status.Text.Split('\n');
            int i = Lines.Length - 1;
            if (i > 0)
            { 
                lastLine = Lines[i - 1];
            }
            
            // Pick which function to run
            switch (lastLine.ToLower().Trim())
            {
                case ("dddd"):
                    
                    break;

                default:
                    break;
            }

        }



    }
}
