﻿// Homework 1

//     Create interfaces called IAnimal, IDog, ICat
//     IAnimal : Contains method PrintAnimal
//     IDog - Contains method Bark
//     ICat - Contains method Eat that gets parameter food of type string
//     Create an abstract class Animal (you choose the properties) that implements IAnimal, with abstract method PrintAnimal
//     Create class Dog that implements IDog and inherits from Animal. Implement PrintAnimal but also Bark.
//     Create class Cat that implements ICat and inherits from Animal. Implement PrintAnimal but also Eat.
//     Create several objects and test the method calls

// The implementation for the methods is on your choice.
using HW_1;

Dog kuce = new Dog();
kuce.AnimalName ="Mitre";
kuce.Age = 5;
kuce.Breed = "Sarplaninec";
kuce.Bark();
kuce.PrintAnimal();

Cat mace = new Cat();
mace.AnimalName = "Tosho";
mace.Age = 2;
mace.Breed = "kontejnerka";
mace.Eat("gluvchenca");
mace.PrintAnimal();
