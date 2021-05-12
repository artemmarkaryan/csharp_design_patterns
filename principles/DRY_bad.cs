using System;


WriteSomething();
WriteSomethingElse();
WriteSomethingAgain();

private static void WriteSomething()
{
    var city = "Novi Sad";
    var state = "Serbia";
    var name = "Milos Protic";
    var age = 30;

    Console.WriteLine($"{name} lives in {city}, {state} and he is {age} years old!");
}

private static void WriteSomethingElse()
{
    var city = "Novi Sad";
    var state = "Serbia";
    var name = "John Doe";
    var age = 29;

    Console.WriteLine($"{name} lives in {city}, {state} and he is {age} years old!");
}
