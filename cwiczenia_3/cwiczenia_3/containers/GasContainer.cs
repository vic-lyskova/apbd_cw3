using cwiczenia_3.interfaces;

namespace cwiczenia_3.containers;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }
    public GasContainer(double cargoWeight, double height, double weight, double depth, string containerType, double maxLoad, double pressure) 
        : base(cargoWeight, height, weight, depth, containerType, maxLoad)
    {
        Pressure = pressure;
    }

    public override void Unload()
    {
        CargoWeight = CargoWeight * 0.05;
    }

    public void Notify()
    {
        Console.WriteLine("Unsafe situation container " + SerialNumber);
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine("Pressure: " + Pressure);
    }
}