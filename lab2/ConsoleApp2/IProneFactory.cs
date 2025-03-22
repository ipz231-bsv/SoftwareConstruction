public class IProneFactory : DeviceFactory
{
    public override ILaptop CreateLaptop()
    {
        return new LaptopIProne();
    }

    public override INetbook CreateNetbook()
    {
        return new NetbookIProne();
    }

    public override IEBook CreateEBook()
    {
        return new EBookIProne();
    }

    public override ISmartphone CreateSmartphone()
    {
        return new SmartphoneIProne();
    }
}
