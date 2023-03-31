using System;

namespace UsingParams
{
    class MainApp
    {

        static int Sum(params int[] abcd)
        {
            Console.Write("Summing... ");

            int sum = 0;

            for (int i = 0; i < abcd.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");

                Console.Write(abcd[i]);

                sum += abcd[i];

            }

            Console.WriteLine();

            return sum;

        }


        static void Main(string[] args)
        {

            int sum = Sum(10,9,4,3,8,7,6,5);

            Console.WriteLine($"Sum : {sum}");


        }
    }
}
