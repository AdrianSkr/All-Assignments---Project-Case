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
            //Opgave 2 

            //Jeg har haft problemer med specifikt at tælle de ulige og lige tal. Dog er de sorteret osv. 
            Random rnd = new Random();
            Console.WriteLine("Computeren udskriver nu 10 tilfældige tal.");

            int randomTal = rnd.Next(1, 10); //Random tal generators, for at gøre det spændende har jeg angivet vise intervaller
            int randomTal2 = rnd.Next(11, 20);
            int randomTal3 = rnd.Next(21, 30);
            int randomTal4 = rnd.Next(31, 40);
            int randomTal5 = rnd.Next(41, 50);
            int randomTal6 = rnd.Next(51, 60);
            int randomTal7 = rnd.Next(61, 70);
            int randomTal8 = rnd.Next(71, 80);
            int randomTal9 = rnd.Next(81, 90);
            int randomTal10 = rnd.Next(91, 100);

            int[] x = new int[] //Et array af vores random tal
            {
                randomTal, 
                randomTal2, 
                randomTal3, 
                randomTal4, 
                randomTal5, 
                randomTal6, 
                randomTal7, 
                randomTal8, 
                randomTal9,
                randomTal10
            };

            Console.WriteLine("Lige tal: ");
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0) //Vores sortering og afgøre af ulige/lige
                {
                    Console.Write("{0} ", x[i]);
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Ulige tal: ");
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 != 0) //Vores sortering og afgøre af ulige/lige
                {
                    Console.Write("{0} ", x[i]);
                }
            }
        }
    }
}


