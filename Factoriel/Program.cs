
while (true)
{
    // See https://aka.ms/new-console-template for more information
    Console.Write("Please insert a number: ");

    var input = Console.ReadLine();
    var intInput = 0;


    //var x = int.Parse(input);

    if (!int.TryParse(input, out intInput))
    {
        Console.WriteLine("Wrong input. Please insert an integer number.");
        return;
    }

    Console.WriteLine(Factoriel(intInput));
}






//int Factoriel(int n)
//{
//    int fact = 1;
//    for(var i = n; i >= 1; i--)
//    {
//        fact*= i;
//    }
//    return fact;
//}


int Factoriel(int n)
{
    if (n == 1)
        return 1;
    else
        return n * Factoriel(n - 1);
}

