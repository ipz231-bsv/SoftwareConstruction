public abstract class DeviceFactory
{
    public abstract ILaptop CreateLaptop();
    public abstract INetbook CreateNetbook();
    public abstract IEBook CreateEBook();
    public abstract ISmartphone CreateSmartphone();
}
