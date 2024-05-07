namespace MyFirstApi.Entities;

public class Laptop : Device
{
    public string GetModel()
    {
        if (IsConnected())
            return "Macbook";

        return "Unknown";
    }

    public override string GetBrand()
    {
        return "Apple";
    }

    public override string GetType()
    {
        return "laptop";
    }
}
