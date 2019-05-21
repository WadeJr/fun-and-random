using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace DirectoriesLib
{
    public class Directories
    {

        public Directories()
        {

        }

        public static List<string> GetSubDirs(string parentDir)
        {
            //If parent directory exist sub directories
            try
            {
                if (Directory.Exists(parentDir))
                {
                    return Directory.GetDirectories(parentDir).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new List<string>();
        }

        public static List<string> GetFiles(string dir)
        {
            //If dir exist get all files 
            try
            {
                if (Directory.Exists(dir))
                {
                    return Directory.GetFiles(dir).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new List<string>();
        }

        public static int CopyDirs(string fromDir, string toDir)
        {
            List<string> dirs = GetSubDirs(fromDir);
            try
            {

                //Create dir if none found
                foreach (var subDir in dirs)
                {
                    string toSubDir = toDir + "//" + subDir.Substring(fromDir.Length);
                    if (!Directory.Exists(toSubDir))
                    {
                        Directory.CreateDirectory(toSubDir);

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dirs.Count;

        }

        public static void CopyFiles(string fromDir, string toDir)
        {
            try
            {
                List<string> from = GetFiles(fromDir);

                //Copy all files if they don't exist
                foreach (var file in from)
                {
                    string toFile = toDir + "//" + file.Substring(fromDir.Length);
                    if (!File.Exists(toFile))
                    {
                        File.Copy(file, toFile);
                    }
                    else if (File.GetLastWriteTime(file) != File.GetLastWriteTime(toFile))
                    {
                        File.WriteAllLines(toFile, File.ReadAllLines(file));
                        File.SetLastWriteTime(toFile, File.GetLastWriteTime(file));
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void CopyAll(string fromDir, string toDir)
        {
            try
            {
                int dirCount = CopyDirs(fromDir, toDir);


                if (dirCount > 0)
                {
                    List<string> fromDirectory = GetSubDirs(fromDir);
                    foreach (var dir in fromDirectory)
                    {
                        string toDirectory = toDir + "//" + dir.Substring(fromDir.Length);
                        CopyFiles(dir, toDirectory);
                        CopyAll(dir, toDirectory);
                    }
                }
                CopyFiles(fromDir, toDir);
            }
            catch (Exception)
            {
                throw;
            }


        }

    }

    public class Synology
    {
        private string fPath;
        private string tPath;


        public Synology(string fromPath, string toPath)
        {
            fPath = fromPath;
            tPath = toPath;
        }

        public void Start()
        {
            try
            {

                Directories.CopyAll(fPath, tPath);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }


}



public class Dbug
{
    public static void Write(string text)
    {
        Debug.AutoFlush = true;
        Debug.Indent();
        Debug.WriteLine("**********************************************************");
        Debug.WriteLine("");
        Debug.WriteLine(text);
        Debug.WriteLine("");
        Debug.WriteLine("----------------------------------------------------------");
        Debug.Unindent();

    }
}

