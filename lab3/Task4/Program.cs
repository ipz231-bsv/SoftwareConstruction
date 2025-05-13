using System;

class Program
{
    static void Main(string[] args)
    {
        ISmartTextReader reader = new SmartTextReaderLocker();
        reader.ReadFile("text1.txt");

        Console.WriteLine("\nТепер спроба доступу до секретного файлу:");
        reader.ReadFile("secret_secret.txt");

        Console.ReadLine();
    }
}
