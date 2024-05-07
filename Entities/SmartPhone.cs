namespace MyFirstApi.Entities;

public class SmartPhone : Device
{
    public string GetModel()
    {
        if (IsConnected())
            return "S24";

        return "Unknown";
    }

    public override string GetBrand()
    {
        return "Samsung";
    }
}
