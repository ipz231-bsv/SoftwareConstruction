public class MobileAppSubscriptionFactory : SubscriptionFactory
{
    public override ISubscription CreateSubscription()
    {
        return new EducationalSubscription();
    }
}
