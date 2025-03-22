public interface ISubscription
{
    decimal MonthlyFee { get; }
    int MinimumSubscriptionPeriod { get; }
    List<string> Channels { get; }
    List<string> Features { get; }

    void DisplaySubscriptionDetails();
}
