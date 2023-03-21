using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapByValue
{
    class MainApp
    {

        public static void Swap (int a, int b,int c)
        {
            int temp = b;
            int temp1 = c;
            b = c;
            a = b;
            c = temp;

            // a -> b , b ->c , c-> a
        }



        static void Main(string[] args)
        {

            int x = 3;
            int y = 4;
            int z = 5;
            Console.WriteLine($"x:{x},y:{y}");

            Swap(x, y,z);

            Console.WriteLine($"x:{x},y:{y}");


        }
    }
}
