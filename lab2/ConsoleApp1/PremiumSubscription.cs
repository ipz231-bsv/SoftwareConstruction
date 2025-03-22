public class PremiumSubscription : ISubscription
{
    public decimal MonthlyFee => 19.99m;
    public int MinimumSubscriptionPeriod => 3;
    public List<string> Channels => new List<string> { "Premium Movies", "Exclusive Sports" };
    public List<string> Features => new List<string> { "4K Streaming", "Offline Downloads", "VIP Support" };

    public void DisplaySubscriptionDetails()
    {
        Console.WriteLine("Premium Subscription Details:");
        Console.WriteLine($"Monthly Fee: ${MonthlyFee}");
        Console.WriteLine($"Minimum Subscription Period: {MinimumSubscriptionPeriod} months");
        Console.WriteLine("Channels: " + string.Join(", ", Channels));
        Console.WriteLine("Features: " + string.Join(", ", Features));
    }
}
