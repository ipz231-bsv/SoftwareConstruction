public class Product
{
    public string Name { get; set; }
    public Money Price { get; set; }

    public Product(string name, Money price)
    {
        Name = name;
        Price = price;
    }

    public void Discount(int discountCents)
    {
        Price.Cents -= discountCents;

        if (Price.Cents < 0)
        {
            Price.Whole -= 1;
            Price.Cents += 100;
        }
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Продукт: {Name}, Ціна: {Price.Whole} грн {Price.Cents} коп.");
    }
}
