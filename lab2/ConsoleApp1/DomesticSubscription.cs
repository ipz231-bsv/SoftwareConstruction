public class DomesticSubscription : ISubscription
{
    public decimal MonthlyFee => 10.99m;
    public int MinimumSubscriptionPeriod => 6;
    public List<string> Channels => new List<string> { "Local News", "Sports" };
    public List<string> Features => new List<string> { "HD Streaming", "Multiple Devices" };

    public void DisplaySubscriptionDetails()
    {
        Console.WriteLine("Domestic Subscription Details:");
        Console.WriteLine($"Monthly Fee: ${MonthlyFee}");
        Console.WriteLine($"Minimum Subscription Period: {MinimumSubscriptionPeriod} months");
        Console.WriteLine("Channels: " + string.Join(", ", Channels));
        Console.WriteLine("Features: " + string.Join(", ", Features));
    }
}
