using System;
using System.Linq;

namespace LottoKupon
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Random rnd = new Random();
            Console.WriteLine("LOTTO KUPON GENERATOR");
            Console.Write("Ønsker du at vælge lykketal? (Ja / Nej): ");
            string answer = Console.ReadLine().ToUpper();
            int[] Lucky = new int[3];
            int xlucky = 0;
            if (answer == "JA" || answer == "J")
            {
                Console.Write("Hvor mange? (1 - 3): ");
                xlucky = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < xlucky; i++)
                {

                    Array.Resize(ref Lucky, xlucky);
                    Console.Write("{0}. Lykketal (1 - 36): ", i + 1);
                    Lucky[i] = Convert.ToInt32(Console.ReadLine());
                    while (Lucky[i] > 36 || Lucky[i] < 1)
                    {
                        Console.Write("{0}. Lykketal (1 - 36): ", i + 1);
                        Lucky[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            if (Lucky[0] != 0)
            {
                foreach (var item in Lucky)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            Console.Write("Hvor mange rækker skal du have? (1 - 10): ");
            int rowcount = Convert.ToInt32(Console.ReadLine());

            while (rowcount > 10 || rowcount < 1)
            {
                Console.Write("Hvor mange rækker skal du have? (1 - 10): ");
                rowcount = Convert.ToInt32(Console.ReadLine());
            }

            int[] Row = new int[7];
            for (int i = 1; i <= rowcount; i++)
            {
                for (int i1 = 0; i1 <= 6; i1++)
                {
                    for (int i2 = 0; i2 + 1 <= xlucky; i2++)
                    {
                        Row[i2] = Lucky[i2];
                    }
                    int tal = rnd.Next(1, 37);
                    while (Row.Contains(tal))
                    {
                        tal = rnd.Next(1, 37);
                    }
                    Row[i1] = tal;
                }
                Array.Sort(Row);
                Console.Write(i + ".\t");
                Console.Write(Row[0] + "\t");
                Console.Write(Row[1] + "\t");
                Console.Write(Row[2] + "\t");
                Console.Write(Row[3] + "\t");
                Console.Write(Row[4] + "\t");
                Console.Write(Row[5] + "\t");
                Console.Write(Row[6] + "\t");
                Console.WriteLine();
            }
        }
    }
}