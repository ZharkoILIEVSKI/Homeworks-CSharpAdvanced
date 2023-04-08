namespace HW_1;

public abstract class Animal : IAnimal
{
    public string AnimalName {get; set;}
    public string Breed {get; set;}
    public int Age {get; set;}

    public abstract void PrintAnimal();
    
}