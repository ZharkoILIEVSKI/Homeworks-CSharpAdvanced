namespace HW_3;

public class FrenchCar : BaseEntity
{
    public override void Drive(string destinationName)
    {
        System.Console.WriteLine($"The french car made by {Brand}, model: {Model} is going to {destinationName}");
    }
}