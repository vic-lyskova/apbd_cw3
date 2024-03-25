namespace cwiczenia_3.interfaces;

public interface IContainer
{
    public void Unload();
    public void Load(double cargoWeight);
    public void GetInfo();
}