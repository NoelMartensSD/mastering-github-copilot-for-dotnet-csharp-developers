using System;

namespace Skills;

public class Members
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public Members(string name, int age, string address, string phoneNumber, string email)
    {
        Name = name;
        Age = age;
        Address = address;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Email: {Email}");
    }
    public string Role { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public Members(string name, int age, string address, string phoneNumber, string email)
    {
        Name = name;
        Age = age;
        Address = address;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Email: {Email}");
    }
}
