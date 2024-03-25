using cwiczenia_3.enums;

namespace cwiczenia_3.containers;

public class RefrigeratedContainer : Container
{
    public ProductType Product { get; set; }
    public double Temperature { get; set; }
    
    public RefrigeratedContainer(double height, double weight, double depth, string containerType, double maxLoad, ProductType product, double temperature) 
        : base(height, weight, depth, containerType, maxLoad)
    {
        Product = product;
        double temp = 0;
        switch (product)
        {
            case ProductType.Bananas:
            {
                temp = 13.3;
                break;
            }
            case ProductType.Chocolate:
            {
                temp = 18;
                break;
            }
            case ProductType.Fish:
            {
                temp = 2;
                break;
            }
            case ProductType.Meat:
            {
                temp = -15;
                break;
            }
            case ProductType.IceCream:
            {
                temp = -18;
                break;
            }
            case ProductType.FrozenPizza:
            {
                temp = -30;
                break;
            }
            case ProductType.Cheese:
            {
                temp = 7.2;
                break;
            }
            case ProductType.Sausages:
            {
                temp = 5;
                break;
            }
            case ProductType.Butter:
            {
                temp = 20.5;
                break;
            }
            case ProductType.Eggs:
            {
                temp = 19;
                break;
            }
        }

        if (temperature < temp)
        {
            temperature = temp;
        }

        Temperature = temperature;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine("Product: " + Product
        + "\nTemperature: " + Temperature);
    }
}