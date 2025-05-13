using System;
using System.IO;

public class SmartTextReader : ISmartTextReader
{
    public void ReadFile(string filePath)
    {
        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), filePath);

        if (!File.Exists(fullPath))
        {
            Console.WriteLine($"Файл не знайдено: {filePath}");
            return;
        }

        string[] lines = File.ReadAllLines(fullPath);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
