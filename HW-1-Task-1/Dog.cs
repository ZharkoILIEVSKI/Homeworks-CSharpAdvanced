namespace HW_1;

public class Dog : Animal, IDog
{
    public void Bark()
    {
        System.Console.WriteLine("Bark, bark, bark");
    }
    public override void PrintAnimal()
    {
        System.Console.WriteLine("I'm a dog");
    }
}
    
