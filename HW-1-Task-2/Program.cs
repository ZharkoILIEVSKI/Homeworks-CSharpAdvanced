// Homework 2

// Car Service

//     Create one abstract class Vehicle with abstract method Drive, and two classes Car and Truck that inherit from Vehicle and override the method Drive.
//     Create 3 interfaces:
//         ICarWash that has methods WashCar that works for Cars, and WashTrailer that works for Trailers.
//         IGasPump that has method PumpGas that works for all vehicles
//         IRepairService that has methods CheckVehicle and FixVehicle that work for all vehicles.
//     Implement each interface in a different class: CarWash, GasPump and RepairService.
//     Implement all interfaces in one class CarCenter.
//     Methods can be implemented with Console.Writeline or changing and checking bools (ex. isClean, isGasFull, isBroken...)

using HW_2;

Car kola = new Car();
kola.Drive();

Truck kamion = new Truck();
kamion.Drive();

CarWash predZgrada = new CarWash();
predZgrada.WashCar();
predZgrada.WashTrailer();

GasPump lukOil = new GasPump();
lukOil.PumpGas();

RepairService majstorZaSiteKoli = new RepairService();
majstorZaSiteKoli.CheckVehicle();
majstorZaSiteKoli.FixVehicle();

CarCenter seksiMotors = new CarCenter();
seksiMotors.FixVehicle();
seksiMotors.CheckVehicle();
seksiMotors.PumpGas();
seksiMotors.WashCar();
seksiMotors.WashTrailer();

