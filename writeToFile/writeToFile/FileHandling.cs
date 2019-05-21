using System.IO;


namespace writeToFile
{
    class FileHandling
    {
        string file_name, path;


        public FileHandling(string fileName)
        {
            file_name = path = fileName;
        }
        public FileHandling()
        {

        }
        public void WriteToFile(string file_name, string[] text)
        {
            File.WriteAllLines(file_name, text);
        }
        public void WriteToFile(string file_name, string text)
        {
            File.WriteAllText(file_name, text);
        }

        public void AppendToFile(string file_name, string[] text)
        {
            File.AppendAllLines(file_name, text);
        }
        public void AppendToFile(string file_name, string text)
        {
            File.AppendAllText(file_name, text);
        }

        public void CopyFileToFile(string file_name, string file_name2)
        {
            File.Copy(file_name, file_name2);
        }

        public void OpenForReading(string path)
        {
            File.OpenRead(path);
        }

        public void OpenForWriting(string path)
        {
            File.OpenWrite(path);
        }

        public void CreateFile(string path)
        {
            File.Create(path);
        }

        public void DeleteFile(string path)
        {
            File.Delete(path);
        }

        public bool Exist(string path)
        {
            return File.Exists(path);
        }

        public void WriteToFile(string[] text)
        {
            File.WriteAllLines(file_name, text);
        }
        public void WriteToFile(string text)
        {
            File.WriteAllText(file_name, text);
        }

        public void AppendToFile(string[] text)
        {
            File.AppendAllLines(file_name, text);
        }
        public void AppendToFile(string text)
        {
            File.AppendAllText(file_name, text);
        }

        public void CopyFileToFile(string file_name2)
        {
            File.Copy(file_name, file_name2);
        }

        public void OpenForReading()
        {
            File.OpenRead(path);
        }

        public void OpenForWriting()
        {
            File.OpenWrite(path);
        }

        public void CreateFile()
        {
            File.Create(path);
        }

        public void DeleteFile()
        {
            File.Delete(path);
        }
        public bool Exist()
        {
            return File.Exists(path);
        }

        public void OpenFolder(string folder_name)
        {
            System.Diagnostics.Process.Start(folder_name);

        }
    }
}
