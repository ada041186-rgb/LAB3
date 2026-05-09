using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class ConsoleLoggerAdapter : ILogger
    {
        private readonly Logger _logger = new();

        public void Log(string message) => _logger.Log(message);
        public void Error(string message) => _logger.Error(message);
        public void Warn(string message) => _logger.Warn(message);
    }
}
