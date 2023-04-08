namespace HW_2;

public static class Validator
{
    public static void Validate(Vehicle nekoe)
    {
        if (nekoe.Id == "")
        {
            System.Console.WriteLine("The Id field is empty...");
        }
        if (nekoe.Type == "")
        {
            System.Console.WriteLine("The Type field is empty...");
        }
        if (nekoe.YearOfProduction == 0)
        {
            System.Console.WriteLine("The production year field is empty");
        }
        else
        {
            System.Console.WriteLine("Data Checked...Everything is  OK");
        }
    }
}