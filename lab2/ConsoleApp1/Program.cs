class Program
{
    static void Main(string[] args)
    {
        SubscriptionFactory websiteFactory = new WebSiteSubscriptionFactory();
        SubscriptionFactory mobileAppFactory = new MobileAppSubscriptionFactory();
        SubscriptionFactory managerCallFactory = new ManagerCallSubscriptionFactory();

        ISubscription websiteSubscription = websiteFactory.CreateSubscription();
        ISubscription mobileAppSubscription = mobileAppFactory.CreateSubscription();
        ISubscription managerCallSubscription = managerCallFactory.CreateSubscription();

        websiteSubscription.DisplaySubscriptionDetails();
        mobileAppSubscription.DisplaySubscriptionDetails();
        managerCallSubscription.DisplaySubscriptionDetails();

        Console.ReadKey();
    }
}
