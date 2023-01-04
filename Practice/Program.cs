namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10.45, y = 15.24;

            Console.WriteLine(Multiply(x));
            Console.WriteLine(Multiply(x, y));
        }



        static double Multiply(double x)
        {
            return 2 * x;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }


    }
}