using System;

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

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {

        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
        }
    }
}
