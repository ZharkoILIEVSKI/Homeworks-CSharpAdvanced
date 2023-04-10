namespace HW_3;

public class GermanCar : BaseEntity
{
    public override void Drive(string destinationName)
    {
        System.Console.WriteLine($"The german car made by {Brand}, model: {Model} is going to {destinationName}");
    }
}