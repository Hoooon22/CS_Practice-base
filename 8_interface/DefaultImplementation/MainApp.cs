using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultImplementation
{
    interface ILogger
    {
        void WriteLog(string message);

        void WriteError(string error)
        {
            WriteLog($"Error : {error}");

        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
        }
    }
}
