using System;

namespace HW_3;

public static class GenericDb<Nekoe> where Nekoe : BaseEntity


{
    public static List<Nekoe> DatabazaNaKoli = new List<Nekoe>();
    public static void InsertingACar(Nekoe kola)
    {
        DatabazaNaKoli.Add(kola);
    }

    public static void GetACarById(int id)
    {
        System.Console.WriteLine(DatabazaNaKoli.FirstOrDefault(x => x.Id == id));
    }

    public static void PrintAllCars(Nekoe kola)
    {
        foreach (Nekoe item in DatabazaNaKoli)
        {
            System.Console.WriteLine($"-------{item}-----------------------");
            System.Console.WriteLine($"        Id: {item.Id}");
            System.Console.WriteLine($"     Model: {item.Model}");
            System.Console.WriteLine($"     Brand: {item.Brand}");
            System.Console.WriteLine($"  Maxspeed: {item.MaxSpeed}[km/h]");
            System.Console.WriteLine($"  FuelType: {item.FuelType}");
            System.Console.WriteLine($"HorsePower: {item.HorsePower} HP");
            System.Console.WriteLine("--------------------------------------");
        }
    }

    public static void Drive(string destinationName)
    {
        System.Console.WriteLine($"Driving...to {destinationName}");
    }
    public static void ColorText(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }

}