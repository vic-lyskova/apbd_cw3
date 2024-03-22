namespace cwiczenia_3.containers;

public abstract class Container
{
    public double CargoWeight { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; } //TODO serial number type and format?
    public double MaxLoad { get; set; }

    protected Container(double cargoWeight, double height, double weight, double depth, string serialNumber, double maxLoad)
    {
        CargoWeight = cargoWeight;
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = serialNumber;
        MaxLoad = maxLoad;
    }
}