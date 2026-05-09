using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TASK1
{
    class FileWriter
    {
        private readonly string _path;

        
        public FileWriter(string path) => _path = path;

        public void Write(string text) =>
            File.AppendAllText(_path, text);

        public void WriteLine(string text) =>
            File.AppendAllText(_path, text + Environment.NewLine);
    }
}
