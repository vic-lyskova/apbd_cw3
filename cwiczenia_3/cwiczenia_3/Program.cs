// See https://aka.ms/new-console-template for more information

using cwiczenia_3.containers;
using cwiczenia_3.enums;
using cwiczenia_3.ships;

RefrigeratedContainer refCont = new RefrigeratedContainer(100, 100, 100, "C", 200, ProductType.Bananas, 13.3);
refCont.Load(100);
Ship ship = new Ship(50, 50, 100);
ship.Load(refCont);
LiquidContainer liqCont = new LiquidContainer(100, 300, 200, "L", 400, true);
liqCont.Load(50);
GasContainer gasCont = new GasContainer(100, 50, 30, "G", 600, 50);
List<Container> containers = new List<Container>();
containers.Add(liqCont);
containers.Add(gasCont);
ship.Load(containers);
ship.Remove(refCont);
ship.Replace("KON-L-2", refCont);
Ship newShip = new Ship(100, 8, 30);
Ship.Move(ship, newShip, gasCont);
ship.Unload();
liqCont.GetInfo();
newShip.GetInfo();