public class Character
{
    public string Name { get; set; }
    public string Height { get; set; }
    public string Build { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Clothes { get; set; }
    public List<string> Inventory { get; set; }
    public List<string> Actions { get; set; } // Для ворогів

    public Character(string name)
    {
        Name = name;
        Inventory = new List<string>();
        Actions = new List<string>();
        Height = "Unknown";
        Build = "Unknown";
        HairColor = "Unknown";
        EyeColor = "Unknown";
        Clothes = "Unknown";
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Height: {Height}");
        Console.WriteLine($"Build: {Build}");
        Console.WriteLine($"Hair Color: {HairColor}");
        Console.WriteLine($"Eye Color: {EyeColor}");
        Console.WriteLine($"Clothes: {Clothes}");
        Console.WriteLine($"Inventory: {string.Join(", ", Inventory)}");
        if (Actions.Count > 0)
            Console.WriteLine($"Evil Actions: {string.Join(", ", Actions)}");
    }
}
