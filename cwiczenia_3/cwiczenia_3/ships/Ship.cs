using cwiczenia_3.containers;

namespace cwiczenia_3.ships;

public class Ship
{
    public HashSet<Container> Containers { get; set; }
    public double MaxSpeed { get; set; }
    public int MaxContainers { get; set; }
    public double MaxContainersWeight { get; set; }

    public Ship(HashSet<Container> containers, double maxSpeed, int maxContainers, double maxContainersWeight)
    {
        Containers = containers;
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxContainersWeight = maxContainersWeight;
    }

    public void Load(Container container)
    {
        Containers.Add(container);
    }

    public void Load(List<Container> containers)
    {
        foreach (var container in containers)
        {
            Containers.Add(container);
        }
    }

    public void Remove(Container container)
    {
        Containers.Remove(container);
    }

    public void Unload()
    {
        Containers.Clear();
    }
}