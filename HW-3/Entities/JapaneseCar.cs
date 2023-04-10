
namespace HW_3;

public class JapaneseCar : BaseEntity
{
    public override void Drive(string destinationName)
    {
        System.Console.WriteLine($"The japanese car made by {Brand}, model: {Model} is going to {destinationName}");
    }
}
