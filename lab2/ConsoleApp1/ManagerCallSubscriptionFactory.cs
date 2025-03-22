public class ManagerCallSubscriptionFactory : SubscriptionFactory
{
    public override ISubscription CreateSubscription()
    {
        return new PremiumSubscription();
    }
}
