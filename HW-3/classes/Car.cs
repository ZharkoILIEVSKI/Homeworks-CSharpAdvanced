namespace HW_3;

public class Car : Vehicle
{
    public int FuelTank { get; set; }

    public string Countries { get; set; }

    public void PrintVehicle(string Type, string Countries)
    {
        System.Console.WriteLine($"The vehicle of the type{Type} is made in {Countries}.... ");
    }
}