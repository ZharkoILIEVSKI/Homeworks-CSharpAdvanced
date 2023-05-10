//Login and register options

Console.WriteLine("==============================================");
Console.WriteLine("====== TIME - TRACKING 2023 Application ======");
Console.WriteLine("==============================================");
Console.WriteLine();

Console.WriteLine("Welcone to the TIME TRACKING Application.");
Console.WriteLine("");
Console.WriteLine("Choose the option of your preference.");
Console.WriteLine("");
Console.WriteLine("1.Login");
Console.WriteLine("2.Register");
Console.Write("Your option: ");


int choise = int.Parse(Console.ReadLine());

if (choise == 1)
{
    Console.WriteLine("==================================================================");
    Console.WriteLine("Please, enter login information:");
    Console.WriteLine();
    Console.Write("Username:");
    string username = Console.ReadLine();
    Console.Write("Password:");
    string password = Console.ReadLine();
}
else if (choise == 2)
{
    Console.WriteLine("==================================================================");
    Console.WriteLine("Please, register your account");
    Console.Write("First Name:");
    string firstname = Console.ReadLine();
    Console.Write("Last Name:");
    string lastname = Console.ReadLine();
    Console.Write("Age: ");
    int age = int.Parse(Console.ReadLine());
    Console.Write("Username:");
    string username = Console.ReadLine();
    Console.Write("Password:");
    string password = Console.ReadLine();
}