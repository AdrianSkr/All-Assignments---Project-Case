using System;

namespace OOPArv
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            string choice = "";
            Console.Write("Areal af Firkant eller cirkel?: ");
            choice = Console.ReadLine().ToLower();

            while(choice != "firkant" && choice != "cirkel"){
                Console.Write("Areal af Firkant eller cirkel?: ");
                choice = Console.ReadLine().ToLower();
            }

            switch (choice)
            {
                case "firkant":
                    Console.Write("Indtast længde: ");
                    double l = Convert.ToDouble(Console.ReadLine());
                    while (l <= 0)
                    {
                        Console.Write("Indtast længde: ");
                        l = Convert.ToDouble(Console.ReadLine());
                    }

                    Console.Write("Indtast bredde: ");
                    double w = Convert.ToDouble(Console.ReadLine());
                    while (w <= 0)
                    {
                        Console.Write("Indtast bredde: ");
                        w = Convert.ToDouble(Console.ReadLine());
                    }

                    Firkant F1 = new Firkant(l, w);
                    Console.WriteLine("{0:N2}", F1.Areal());
                    break;

                case "cirkel":

                    Console.Write("Indtast radius: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    while (r <= 0)
                    {
                        Console.Write("Indtast radius: ");
                        w = Convert.ToDouble(Console.ReadLine());
                    }

                    Cirkel C1 = new Cirkel(r);
                    Console.WriteLine(C1.Areal());
                    break;
            }
        }
    }
}
