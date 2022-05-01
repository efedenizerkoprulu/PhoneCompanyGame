using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Log.FileLogger
{
    public interface ILog
    {
        void CreateLog(string fileName);
        void WriteLog(string fileName, string text);
        bool IslogExsist(string fileName);
        string Path { get; set; }
    }
}
