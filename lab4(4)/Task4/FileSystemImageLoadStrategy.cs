public class FileSystemImageLoadStrategy : IImageLoadStrategy
{
    public void LoadImage(string href)
    {
        Console.WriteLine($"Завантаження зображення з файлової системи: {href}");
    }
}
