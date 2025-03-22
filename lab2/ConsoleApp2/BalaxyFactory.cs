public class BalaxyFactory : DeviceFactory
{
    public override ILaptop CreateLaptop()
    {
        return new LaptopBalaxy();
    }

    public override INetbook CreateNetbook()
    {
        return new NetbookBalaxy();
    }

    public override IEBook CreateEBook()
    {
        return new EBookBalaxy();
    }

    public override ISmartphone CreateSmartphone()
    {
        return new SmartphoneBalaxy();
    }
}
