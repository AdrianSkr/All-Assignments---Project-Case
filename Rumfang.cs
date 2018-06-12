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
            //Opgave 1

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
        }
    }
}


