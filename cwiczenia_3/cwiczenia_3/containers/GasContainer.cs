using cwiczenia_3.interfaces;

namespace cwiczenia_3.containers;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double cargoWeight, double height, double weight, double depth, string containerType, double maxLoad) : base(cargoWeight, height, weight, depth, containerType, maxLoad)
    {
    }

    public override void Unload()
    {
        base.Unload();
    }

    public void Notify(string serialNumber)
    {
        Console.WriteLine("Unsafe situation container " + serialNumber);
    }
}