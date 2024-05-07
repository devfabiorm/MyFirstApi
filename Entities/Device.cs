namespace MyFirstApi.Entities;

public abstract class Device
{
    protected bool IsConnected() => true;

    public abstract string GetBrand();

    public virtual string GetType()
    {
        return "Unknown";
    }
}
