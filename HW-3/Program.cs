using System.Net;
// ###Homework Generics

//     Crate a car dealership app. Make a BaseEntity abstract class with properties Id, Brand, Model, MaxSpeed, HorsePower, FuelType and a abstract method Drive(string destinationName).
//     Create other classes for JapaneseCar, GermanCar, FrenchCar, ItalianCar, AmericanCar that will inherit from the BaseEntity.
//     Make a generic database named GenericDb that will only take in classes that INHERIT FROM THE BaseEntity.
//     In the generic database create methods for Inserting a car, Get a car by id, Print all cars.
//     Create an extension method that will change the color of a text, just like we learned in class.
 using HW_3;

 JapaneseCar yamamoto = new JapaneseCar()
 {
     Id = 1,
     Brand = "Toyota",
     Model = "S345",
     MaxSpeed = 200,
     HorsePower = 100,
     FuelType = FuelType.CNG,
 };


GenericDb<BaseEntity>.InsertingACar(yamamoto);

GermanCar fritz = new GermanCar()
 {
    Id = 2,
    Brand = "BMW",
    Model = "M230d",
    MaxSpeed = 220,
    HorsePower = 160,
    FuelType = FuelType.Diesel
 };

GenericDb<BaseEntity>.InsertingACar(fritz);

FrenchCar pierre = new FrenchCar()
 {
    Id = 3,
    Brand = "Citroen",
    Model = "C4-Sport",
    MaxSpeed = 200,
    HorsePower = 110,
    FuelType = FuelType.Petrol
 };

GenericDb<BaseEntity>.InsertingACar(pierre);

ItalianCar paolo = new ItalianCar()
 {
    Id = 4,
    Brand = "Ferrari",
    Model = "Testarossa",
    MaxSpeed = 280,
    HorsePower = 189,
    FuelType = FuelType.Petrol
 };

GenericDb<BaseEntity>.InsertingACar(paolo);

AmericanCar johny = new AmericanCar()
 {
    Id = 5,
    Brand = "Dodge",
    Model = "Charger",
    MaxSpeed = 230,
    HorsePower = 150,
    FuelType = FuelType.Petrol
 };

GenericDb<BaseEntity>.InsertingACar(johny);

System.Console.WriteLine("---------------------------------------------------");

GenericDb<BaseEntity>.PrintAllCars(johny);

string text = "Mnogu e tapa kodov, ama ke go pustime u temno-crvena boja da bide :)";
GenericDb<BaseEntity>.ColorText(text,ConsoleColor.DarkRed);

System.Console.WriteLine("---------------------------------------------------");


