namespace HW_2;

public class Bike : Vehicle
{
    public string Color{get;set;}

    public void PrintVehicle(int YearOfProduction, string Color)
    {
        System.Console.WriteLine($"The bike made in year {YearOfProduction} is a {Color} color");
    }
}