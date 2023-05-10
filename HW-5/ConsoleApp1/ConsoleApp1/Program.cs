//Homework
//Task1

//Create a Dog class with :
//Name, Age, Color
//Let the user input these parameters from a console application
//Create a new Dog object from the inputs and write it as a json in a new file on the file system
//The content of the json should be array
//Create a method that reads and prints in the console all the dogs from the txt file

using ConsoleApp1.Entities;
using Newtonsoft.Json;

string folderPath = "../../../DogFolder";
string filePath = folderPath + "/dog.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}

void WriteToJson(string json)
{
    using (StreamWriter sw = new StreamWriter(filePath))
    {
        sw.WriteLine(json);
    }
}

void ReadFromJson()
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
}


Console.WriteLine("------- Dog Aplikacija --------");
Console.WriteLine();

Console.Write("Vnesete ime na kuce: ");
string name = Console.ReadLine();

Console.Write("Vnesete starost na kuce: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Vnesete boja na kuce: ");
string color = Console.ReadLine();

Dog dog = new Dog()
{
    Name = name,
    Age = age,
    Color = color,
};

Dog [] kucencenca = new Dog[] { dog };
kucencenca[0] = dog;

string dogString = JsonConvert.SerializeObject(kucencenca);
WriteToJson(dogString);

ReadFromJson();