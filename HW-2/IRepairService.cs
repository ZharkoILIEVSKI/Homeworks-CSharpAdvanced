namespace HW_2;

public interface IRepairService
{
    public void CheckVehicle()
    {
        System.Console.WriteLine("Voziloto e provereno...");
    }
    public void FixVehicle()
    {
        System.Console.WriteLine("Voziloto e popraveno...");
    }
}