namespace HW_2;

public class CarWash : ICarWash
{
    public void WashCar()
    {
        System.Console.WriteLine("Mienje na koli");
    }

    public void WashTrailer()
    {
        System.Console.WriteLine("Mienje na prikolici");
    }
}