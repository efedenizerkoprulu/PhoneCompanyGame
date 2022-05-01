using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Log.FileLogger
{
    public class Log : ILog
    {
        public string Path { get; set; }

        public void CreateLog(string fileName)
        {
            FileStream fs = File.Create(@"Log\"+ fileName + "AccountLog.txt");
            fs.Close();
        }

        public bool IslogExsist(string fileName)
        {
            string path = @"Log\" + fileName + "AccountLog.txt";
            bool isExsistFile = File.Exists(path);
            if (isExsistFile)
            {
               Path = path;
                return true;
            }
            else
            {
                CreateLog(fileName);
                return false;
            }
        }

        public void WriteLog(string fileName,string text)
        {
            if (IslogExsist(fileName))
            {
                StreamWriter sw = new StreamWriter(Path);
                sw.WriteLine("Date and Time: "+DateTime.Now + "Error masage:" + text);
                sw.Close();
            }
        }
    }
}
