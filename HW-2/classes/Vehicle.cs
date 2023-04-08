using System.Runtime.Serialization;
using System;
using System.Security;
namespace HW_2;

public class Vehicle
{
    public string Id {get;set;}
    public string Type {get;set;}
    public int YearOfProduction{get;set;}
    public string BatchNumber{get;set;}
    
    public void PrintVehicle(/*string Id, string Type, int YearOfProduction*/)
    {
        System.Console.WriteLine($"The car with Id:{Id} of type {Type} and made in {YearOfProduction} is driven on the Partizanska boulevard.....");
    }


}