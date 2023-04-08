
    // Homework

    // Create a class Vehicle with properties Id, Type, YearOfProduction, BatchNumber.
    // Create two classes Car and Bike that inherit from Vehicle. Car has property FuelTank (int) and Countries in which it is produced and Bike has property Color.
    // Class Vehicle has method PrintVehicle that prints Id, Type and YearOfProduction.
    // Class Car also has method PrintVehicle that prints the Type and the Countries in which it is produced.
    // Class Bike also has method PrintVehicle that Prints the YearOfProduction and the Color.
    // Create a static class that serves as a DB, that has list of Vehicles. In this list put objects of type Car, Bike and Vehicle.
    // In the main program call PrintVehicle for each object in the list in the db.
    // Create a static class called Validator, that contains a method Validate, that receives a Vehicle and validates is Id is not 0, that Type is not empty and YearOfProduction is not 0.
    // Call Validate from main Program with a couple of objects.

using HW_2;

Vehicle vozilo = new Vehicle();
vozilo.Id = "SK-1111-AA";
vozilo.Type = "CAR - MERCEDES A650";
vozilo.BatchNumber = "W1234WER345";
vozilo.YearOfProduction = 1989;
FakeDatabase.listaNaVozila.Add(vozilo);

Car fikjo = new Car();
fikjo.Id = "SK-0001-BB";
fikjo.Type = "CAR - Fiat 750";
fikjo.BatchNumber = "W0014WER100";
fikjo.YearOfProduction = 1972;
FakeDatabase.listaNaVozila.Add(fikjo);

Bike trek = new Bike();
trek.Id = "00-0000-ZI";
trek.Type = "BIKE - Trek Domane SLR 9";
trek.BatchNumber = "US14WER100";
trek.YearOfProduction = 2023;
FakeDatabase.listaNaVozila.Add(trek);

System.Console.WriteLine(FakeDatabase.listaNaVozila[0]);
System.Console.WriteLine(FakeDatabase.listaNaVozila[1]);
System.Console.WriteLine(FakeDatabase.listaNaVozila[2]);

System.Console.WriteLine("--------");
System.Console.WriteLine("Ova e izvadok od Databazata");
System.Console.WriteLine("--------");

for (int i = 0; i < FakeDatabase.listaNaVozila.Count; i++)
{
FakeDatabase.listaNaVozila[i].PrintVehicle();
}

System.Console.WriteLine("--------");
System.Console.WriteLine("Proverka niz validacija");
System.Console.WriteLine("--------");

Validator.Validate(vozilo);
Validator.Validate(fikjo);
Validator.Validate(trek);