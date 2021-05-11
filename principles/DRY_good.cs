using System;

WriteSomething();
WriteSomethingElse();
WriteSomethingAgain();
Console.ReadLine();

public static class Constants
{
    public const string CITY = "Novi Sad";
    public const string STATE = "Serbia";
}

public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string State => Constants.STATE;
    public string City => Constants.CITY;
    public int Age { get; set; }
    public string Name { get; set; }

    public void PrintInformation()
    {
        Console.WriteLine($"{Name} lives in {City}, " +
          $"{State} and he is {Age} years old!");
    }
}

private static void WriteSomething()
{ new Person("Milos Protic", 30).PrintInformation(); }

private static void WriteSomethingElse()
{ new Person("John Doe", 29).PrintInformation(); }

private static void WriteSomethingAgain()
{ new Person("Jack Fishing", 49).PrintInformation(); }
