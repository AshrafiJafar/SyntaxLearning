using System;


var fistNumber = "123";
var secondNumber = "321";

Console.WriteLine(int.Parse(fistNumber) + int.Parse(secondNumber));

Console.Write("Please type your name: ");

var input = Console.ReadLine();


var inputLowerCase = input.ToLower();


if (inputLowerCase == "jafar")
{
    Console.Write("Please insert your password:");
    var password = Console.ReadLine();
    if (password == "wTrdei")
    {
        Console.WriteLine("Welcome System Admin");
    }
    else
    {
        Console.WriteLine("Wrong password.");
    }
} else if(inputLowerCase == "hamidreza")
{
    Console.Write("Please insert your password:");
    var password = Console.ReadLine();
    if (password == "123456")
    {
        Console.WriteLine("Welcome System Support");
    }
    else
    {
        Console.WriteLine("Wrong password.");
    }
}




