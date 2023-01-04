namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] scores = { 15, 14, 20, 18, 8 };

            //Array.Sort(scores);
            //Console.WriteLine(scores[5]);


            //for (int i = 0; i < scores.Length /*5*/; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //foreach(int i in scores)
            //{
            //    Console.WriteLine(i);
            //}


            //int[,] lst = {
            //    { 1, 2, 3 },
            //    { 5, 6, 7 },
            //    { 4, 8, 9 }
            //};


            //for(int k = 0; k < lst.GetLength(0); k++)
            //{
            //    Console.WriteLine(lst[k,2]);
            //}
            //int[,] lst2 = { 
            //    { 4, 8, 9 },
            //    { 1, 2, 3 },
            //    { 5, 6, 7 }
            //};



            //for (int i = 0; i < lst.GetLength(0); i++)
            //{
            //    for (int j = 0; j < lst.GetLength(0); j++)
            //    {
            //        Console.Write(lst[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 0; i < lst.GetLength(0); i++)
            //{
            //    for (int j = 0; j < lst.GetLength(0); j++)
            //    {
            //        Console.Write(lst[i, j] + lst2[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            double[] studentScores = { 15, 14, 20, 18, 8, 15, 12.5, 17.25, 19.5, 7.25 };

            Console.WriteLine(Sum(studentScores));


        }


        static double Sum(double[] nums)
        {
            double summation = 0;
            foreach(var item in nums)
            {
                summation+= item;
            }
            return summation;
        }
    }
}