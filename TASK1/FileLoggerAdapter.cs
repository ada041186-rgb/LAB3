using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class FileLoggerAdapter : ILogger
    {
        private readonly FileWriter _writer;

        public FileLoggerAdapter(string filePath) =>
            _writer = new FileWriter(filePath);

        public void Log(string message) =>
            _writer.WriteLine($"[LOG]   {DateTime.Now:HH:mm:ss} {message}");

        public void Error(string message) =>
            _writer.WriteLine($"[ERROR] {DateTime.Now:HH:mm:ss} {message}");

        public void Warn(string message) =>
            _writer.WriteLine($"[WARN]  {DateTime.Now:HH:mm:ss} {message}");
    }
}
