public class KiaomiFactory : DeviceFactory
{
    public override ILaptop CreateLaptop()
    {
        return new LaptopKiaomi();
    }

    public override INetbook CreateNetbook()
    {
        return new NetbookKiaomi();
    }

    public override IEBook CreateEBook()
    {
        return new EBookKiaomi();
    }

    public override ISmartphone CreateSmartphone()
    {
        return new SmartphoneKiaomi();
    }
}
