namespace HW_2;

public class CarCenter : ICarWash, IGasPump, IRepairService
{
    public void CheckVehicle()
    {
        System.Console.WriteLine("Voziloto e provereno...");
    }

    public void FixVehicle()
    {
        System.Console.WriteLine("Voziloto e POPRAVENO...");
    }

    public void PumpGas()
    {
        System.Console.WriteLine("Voziloto e NAPOLNETO so gorivo");
    }

    public void WashCar()
    {
        System.Console.WriteLine("Voziloto e IZMIENO...");
    }

    public void WashTrailer()
    {
        System.Console.WriteLine("Prikolkata e IZMIENA...");
    }
}