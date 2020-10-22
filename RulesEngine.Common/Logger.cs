using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.Common
{
    public class Logger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Logger: {message}");
        }
    }
}
