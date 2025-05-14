public class NetworkImageLoadStrategy : IImageLoadStrategy
{
    public void LoadImage(string href)
    {
        Console.WriteLine($"Завантаження зображення з мережі: {href}");
    }
}
