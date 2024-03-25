using cwiczenia_3.interfaces;

namespace cwiczenia_3.containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public LiquidContainer(double cargoWeight, double height, double weight, double depth, string containerType, double maxLoad) : base(cargoWeight, height, weight, depth, containerType, maxLoad)
    {
    }

    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
    }

    public void Notify(string serialNumber)
    {
        Console.WriteLine("Unsafe situation container " + serialNumber);
    }
}