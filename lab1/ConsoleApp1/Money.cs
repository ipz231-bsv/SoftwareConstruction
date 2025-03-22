public class Money
{
    public int Whole { get; set; }
    public int Cents { get; set; }

    public Money(int whole, int cents)
    {
        Whole = whole;
        Cents = cents;
    }

    public void DisplayAmount()
    {
        Console.WriteLine($"Сума: {Whole} гривень, {Cents} копійок");
    }

    public void SetAmount(int whole, int cents)
    {
        Whole = whole;
        Cents = cents;
    }
}
