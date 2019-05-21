using System.Diagnostics;

namespace CmdLib
{
    public class Cmd
    {
        private Process process = new Process();
        public string Output = "nada";

        public Cmd()
        {
            
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Verb = "runas";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();

        }
    
       
     

        public void WriteCommand(string text)
        {
            process.StandardInput.WriteLine(text);
            process.StandardInput.Flush();
            Output = process.StandardOutput.ReadToEnd();
        }



        public void EndProcess()
        {
            process.StandardInput.Close();
            process.WaitForExit();
   
        }

       

    }
}
