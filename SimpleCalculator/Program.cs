
Console.Write("Please insert first number: ");

var firstNumberString = Console.ReadLine();
var firstNumber = double.Parse(firstNumberString);
Console.Write("Please insert operator: ");

var op = Console.ReadLine();

Console.Write("Please insert Second number: ");

var secondNumberString = Console.ReadLine();
var secondNumber = double.Parse(secondNumberString);

double result;

//if (op == "+")
//    result = firstNumber + secondNumber;
//else if (op == "-")
//    result = firstNumber - secondNumber;
//else if (op == "*")
//    result = firstNumber * secondNumber;
//else if (op == "/")
//    result = firstNumber / secondNumber;
//else
//{
//    Console.WriteLine("Operator should be one of arithmatic signs.");
//    return;
//}
//Console.WriteLine(firstNumberString + " " + op + " " + secondNumberString + " = " + result);


switch (op)
{
    case "+":
        result = firstNumber + secondNumber;
        break;
    case "-":
        result = firstNumber - secondNumber;
        break;
    case "*":
        result = firstNumber * secondNumber;
        break;
    case "/":
        result = firstNumber / secondNumber;
        break;
    case "^":
        result = Power(firstNumber, secondNumber);
        break;
    default:
        Console.WriteLine("Operator should be one of arithmatic signs.");
        return;
}
Console.WriteLine(firstNumberString + " " + op + " " + secondNumberString + " = " + result);


double Power(double number, double pow)
{
    double result = 1;
    //for (var i = secondNumber; i >= 1; i--)
    //{
    //    result *= firstNumber;
    //}
    while (pow >= 1)
    {
        result *= number;
        pow--;
    }
    return result;
}


//int i = 0;
//int j = 1;
//while(i < 100 && j < 5 )
//{
//    Console.WriteLine(i);
//    i++;
//    j++;
//}

//                      i = i + 1
//                      i += 1;
//                      i++;
//int i = 1;
//for ( ; ; )
//{
//    Console.WriteLine(2 * i);
//    i++;
//    if (i > 25)
//        break;
//}
//Console.WriteLine("Loop has been finished!");



//for (var i = 1; i< 51 ; i++)
//{
//    if (i % 2 == 1)
//        continue;
//    Console.WriteLine(i);
//}
//Console.WriteLine("Loop has been finished!");

