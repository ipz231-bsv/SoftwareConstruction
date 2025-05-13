using Lab3.Patterns;
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Console Logger ==");
            var consoleLogger = new Logger();
            consoleLogger.Log("This is a log message");
            consoleLogger.Warn("This is a warning");
            consoleLogger.Error("This is an error");

            Console.WriteLine("\n== File Logger ==");
            var fileWriter = new FileWriter("log.txt");
            var fileLogger = new FileLoggerAdapter(fileWriter);
            fileLogger.Log("This is a log message (file)");
            fileLogger.Warn("This is a warning (file)");
            fileLogger.Error("This is an error (file)");

            Console.WriteLine("Записи додано до log.txt");
            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();

        }
    }
}
