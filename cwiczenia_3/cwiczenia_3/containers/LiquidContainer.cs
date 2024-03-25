using cwiczenia_3.interfaces;

namespace cwiczenia_3.containers;

public class LiquidContainer : Container, IHazardNotifier
{
    
    public bool UnsafeCargo { get; set; }
    public LiquidContainer(double cargoWeight, double height, double weight, double depth, string containerType, double maxLoad, bool unsafeCargo) 
: base(cargoWeight, height, weight, depth, containerType, maxLoad)
    {
        UnsafeCargo = unsafeCargo;
    }

    public override void Load(double cargoWeight)
    {
        if (UnsafeCargo)
        {
            if (cargoWeight < MaxLoad / 2)
            {
                base.Load(cargoWeight);
            }
            else
            {
                Notify();
            }
        }
        else
        {
            if (cargoWeight < MaxLoad * 0.9)
            {
                base.Load(cargoWeight);
            }
            else
            {
                Notify();
            }
        }
    }

    public void Notify()
    {
        Console.WriteLine("Unsafe situation container " + SerialNumber);
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine("Unsafe cargo: " + UnsafeCargo);
    }
}