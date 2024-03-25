using cwiczenia_3.exceptions;
using cwiczenia_3.interfaces;

namespace cwiczenia_3.containers;

public abstract class Container : IContainer
{
    private static int _serialNumberDigit = 0;
    
    public double CargoWeight { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; }
    public double MaxLoad { get; set; }

    protected Container(double height, double weight, double depth, string containerType, double maxLoad)
    {
        CargoWeight = 0;
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = "KON" + "-" + containerType + "-" + ++_serialNumberDigit;
        MaxLoad = maxLoad;
    }

    public virtual void Unload()
    {
        CargoWeight = 0;
    }

    public virtual void Load(double cargoWeight)
    {
        if (cargoWeight > MaxLoad)
        {
            throw new OverfillException();
        }

        CargoWeight = cargoWeight;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine("Container serial number: " + SerialNumber
        + "\nCharacteristics:"
        + "\nCargo weight: " + CargoWeight 
        + "\nHeight: " + Height
        + "\nWeight: " + Weight
        + "\nDepth: " + Depth
        + "\nMax load: " + MaxLoad);
    }
}