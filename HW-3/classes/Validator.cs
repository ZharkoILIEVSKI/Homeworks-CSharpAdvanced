namespace HW_3;

public static class Validator 
{
    public void Validate(Vehicle nekoe)
    {
        if(nekoe.Id == "")
        {
            System.Console.WriteLine("The Id field is empty...");
        }
        if(nekoe.Type =="")
        {
             System.Console.WriteLine("The Type field is empty...");
        }
          if(nekoe.YearOfProduction == 0)
        {
             System.Console.WriteLine("The production year field is empty");
        }
    }
}