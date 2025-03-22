public class WebSiteSubscriptionFactory : SubscriptionFactory
{
    public override ISubscription CreateSubscription()
    {
        return new DomesticSubscription();
    }
}
