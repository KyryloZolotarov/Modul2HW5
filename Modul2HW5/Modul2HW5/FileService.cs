using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW5
{
    internal class FileService
    {
        private string[] logs = Array.Empty<string>();
        public void StoreLog(string message)
        {
            var length = logs.Length;
            Array.Resize(ref logs, newSize: length + 1);
            logs[length] = message;
        }

        public string DisplayLogs()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string item in logs)
            {
                stringBuilder.AppendLine(item);
            }

            return stringBuilder.ToString();
        }

        public void SaveToFile()
        {
            CheckFileHistory();
            var fileExtention = ".txt";
            var fileName = DateTime.Now.ToString("hh.mm.ss dd.MM.yyyy") + fileExtention;
            var configurations = new ConfigReader().GetConfigurations();
            if (!Directory.Exists(configurations.LogFolderName))
                {
                    Directory.CreateDirectory(configurations.LogFolderName);
                }

            var pathToFile = Path.Combine(configurations.LogFolderName, fileName);
            File.WriteAllText(pathToFile, DisplayLogs());
        }

        public void CheckFileHistory()
        {
            var configurations = new ConfigReader().GetConfigurations();
            if (!Directory.Exists(configurations.LogFolderName))
            {
                return;
            }

            var directoryFiles = Directory.EnumerateFiles(configurations.LogFolderName).ToArray();
            Array.Sort(directoryFiles);
            Array.Reverse(directoryFiles);
            if (directoryFiles.Length >= 2)
            {
                for (int i = 2; i < directoryFiles.Length; i++)
                {
                    File.Delete(directoryFiles[i]);
                }
            }
        }
    }
}
