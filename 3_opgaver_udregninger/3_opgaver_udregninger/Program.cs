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

            //Opgave 2 
            /*
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
            */

            //Opgave 1
            /*
            string txt = "Du har nu udregnet dit rumfang.";

            Console.WriteLine("Program om beregning af matematiske formler.");

            Console.WriteLine("Hvilken udregning kunne du tænke dig at udføre? ");
            Console.WriteLine("RK = Kasse rumfang: ");
            Console.WriteLine("RC = Cylinder rumfang: ");
            Console.WriteLine("RP = Prisme rumfang: ");
            string type = Console.ReadLine();

            if (type == "RK" || type == "rk")
            {
                Console.WriteLine("Du vil beregne rumfanget af en kasse.");

                Console.WriteLine("Indtast højde: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Indtast bredde: ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Indtast længde: ");
                double length = Convert.ToDouble(Console.ReadLine());

                double volume = height * width * length;

                Console.WriteLine("Dit rumfang lyder på: {0:N2} kubikmeter/kubikcentimeter/kubikkilometer.", volume);

                if(type=="rk" || type=="RK")
                {
                    Console.WriteLine(txt);
                }


            }

            else if(type =="RC" || type=="rc")
            {
                Console.WriteLine("Du vil beregne rumfanget af en cylinder.");

                Console.WriteLine("Indtast højde: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Indtast radius: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                double grundareal = (Math.Pow(radius, 2) * Math.PI);
                double volume = height * grundareal;

                Console.WriteLine("Dit grundareal lyder på: {0}", grundareal);
                Console.WriteLine("Dit rumfang lyder på: {0:N2}", volume);

                if (type == "rc" || type == "RC")
                {
                    Console.WriteLine(txt);
                }


            }

            else if(type =="RP" || type=="rp")
            {
                Console.WriteLine("Du vil beregne rumfanget af en prisme.");

                Console.WriteLine("Indtast højde: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Indtast grundlinje: ");
                double groundline = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Indtast højde på bunden af din prisme (fra grundlinjen): ");
                double grundHeight = Convert.ToDouble(Console.ReadLine());

                double grundareal2 = groundline * (grundHeight / 2);
                double volume = height * grundareal2;

                Console.WriteLine("Dit grundareal lyder på: {0}", grundareal2);
                Console.WriteLine("Dit rumfang lyder på: {0:N2}", volume);

                if (type == "RP" || type == "rp")
                {
                    Console.WriteLine(txt);
                }
            }
            */
        }
    }
}


