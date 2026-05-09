using System;
using System.IO;
using System.Text;


namespace TASK1
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            const string logFile = "app.log";
            if (File.Exists(logFile)) File.Delete(logFile);

            Console.WriteLine("--- ConsoleLoggerAdapter ---");
            ILogger consoleLogger = new ConsoleLoggerAdapter();
            consoleLogger.Log("Програму запущено");
            consoleLogger.Warn("Залишилось мало пам'яті");
            consoleLogger.Error("Підключення до БД відмовлено");

            Console.WriteLine("\n--- FileLoggerAdapter ---");
            ILogger fileLogger = new FileLoggerAdapter(logFile);
            fileLogger.Log("Програму запущено");
            fileLogger.Warn("Залишилось мало пам'яті");
            fileLogger.Error("Підключення до БД відмовлено");

            Console.WriteLine($"Записи збережено у файл: {Path.GetFullPath(logFile)}");

            Console.WriteLine("\n--- Вміст app.log ---");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(File.ReadAllText(logFile));
            Console.ResetColor();
        }
    }
}
