// See https://aka.ms/new-console-template for more information
Console.Write("Please insert first number: ");
var num1 = Console.ReadLine();
Console.Write("Please insert second number: ");
var num2 = Console.ReadLine();

var num1int = int.Parse(num1);
var num2int = int.Parse(num2);

//var bmm = BMM(num1int, num2int);
//var kmm = KMM(num1int, num2int);

//Console.WriteLine($"BMM: {bmm},       KMM: {kmm}");


var result1 = Sum.Add(num1, num2);

var result = Sum.Add(num1int, num2int);


int KMM(int x , int y)
{
    return x * y / BMM(x, y);
}


int BMM(int x, int y)
{
    int max = 0;
    int min = 0;

    if (x >= y)
    {
        max = x;
        min = y;
    }
    else
    {
        max = y;
        min = x;
    }
    while (max % min != 0)
    {
        var bagimande = max % min;

        max = min;
        min = bagimande;
    }
    return min;
}


class Sum
{
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Add(string x, string y)
    {
        return int.Parse(x) + int.Parse(y) ;
    }
}

   

