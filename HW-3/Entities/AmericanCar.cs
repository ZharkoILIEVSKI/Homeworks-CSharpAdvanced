namespace HW_3;

public class AmericanCar : BaseEntity
{
    public override void Drive(string destinationName)
    {
        System.Console.WriteLine($"The american car made by{Brand}, model: {Model} is going to {destinationName}");
    }
}
