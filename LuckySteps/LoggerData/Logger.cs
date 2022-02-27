using System;
using System.Collections.Generic;
using System.IO;

namespace LuckySteps.LoggerData
{
    class Logger
    {
        private string _path = $@"//LoggerFiles//{DateTime.Now.ToString("yyyyMMdd")}.txt";
        private static Logger _instance;
        private Logger()
        { }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void Error(string message)
        {
            this.Log(message);
        }

        public void Info(string message)
        {
            this.Log(message);
        }

        public void Log(string message)
        {
            File.AppendAllText(_path, $"{DateTime.Now.ToString("hh.MM.ss")}. {message}");
        }
    }
}
