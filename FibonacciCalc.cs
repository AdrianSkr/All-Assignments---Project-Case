using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _opgaver_udregninger
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int fibonacci = 0;
            int a = 0;
            int temp = a;
            int b = 1;

            Console.WriteLine("FiboCalc");
            Console.Write("Indtast et tal?: ");
            int fiboInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; b <= fiboInput; i++)
            {
                fibonacci = b;
                temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine("Dit højeste fibonacci tal er: " + fibonacci);
            Console.WriteLine("Laveste fibonacci tal efter rækken er: " + b);

        }
    }
}


