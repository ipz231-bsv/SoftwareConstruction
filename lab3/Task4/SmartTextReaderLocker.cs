using System;

public class SmartTextReaderLocker : ISmartTextReader
{
    private readonly SmartTextReader _reader = new SmartTextReader();

    public void ReadFile(string filePath)
    {
        if (filePath.ToLower().Contains("secret"))
        {
            Console.WriteLine($"[БЛОКУВАННЯ] Доступ до файлу \"{filePath}\" заборонено.");
            return;
        }

        _reader.ReadFile(filePath);
    }
}
