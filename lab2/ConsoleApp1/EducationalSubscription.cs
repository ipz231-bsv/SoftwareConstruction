public class EducationalSubscription : ISubscription
{
    public decimal MonthlyFee => 8.99m;
    public int MinimumSubscriptionPeriod => 12;
    public List<string> Channels => new List<string> { "Math Channel", "History Channel" };
    public List<string> Features => new List<string> { "Educational Content", "Progress Tracking" };

    public void DisplaySubscriptionDetails()
    {
        Console.WriteLine("Educational Subscription Details:");
        Console.WriteLine($"Monthly Fee: ${MonthlyFee}");
        Console.WriteLine($"Minimum Subscription Period: {MinimumSubscriptionPeriod} months");
        Console.WriteLine("Channels: " + string.Join(", ", Channels));
        Console.WriteLine("Features: " + string.Join(", ", Features));
    }
}
