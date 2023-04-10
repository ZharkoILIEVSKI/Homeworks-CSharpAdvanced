namespace HW_3;

public class ItalianCar : BaseEntity
{
    public override void Drive(string destinationName)
    {
        System.Console.WriteLine($"The italian car made by {Brand}, model: {Model} is going to {destinationName}");
    }
}