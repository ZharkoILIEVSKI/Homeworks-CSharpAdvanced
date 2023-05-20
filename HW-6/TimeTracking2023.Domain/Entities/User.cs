using System;
using TimeTracking2023.Domain;

public class User : BaseEntity
{
    public int UserId { get; set; }
    public string FirstName { get; set; } =string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }

    public string Username { get; set; }
    public string Password { get; set; }

    public User(string firstName, string lastName, int age, string username, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Username = username;
        Password = password;
    }


    public override string Print()
    {
       // return $"User with username: [{Username}] and role: [{Role}]";
    }
}
