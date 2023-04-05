namespace HW_1;
public class Cat : Animal, ICat
{
    public void Eat(string food)
    {
        System.Console.WriteLine($"Eating {food}");
    }
    public override void PrintAnimal()
    {
        System.Console.WriteLine("I'm a cat");;
    }
}
