using System;

namespace TerningKast
{
    class GetSet
    {
        public int mitKast;
        private int Kast
        {
            get { return mitKast; }
            set { Kast = value; }
        }
    }
    class Kast
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("**Random Terning Kast**");

            int number = 0;

            Random rnd = new Random();

            for (int x = 1; x <=5; x++)
            {
                number = rnd.Next(1, 7);
                Console.WriteLine(number);

            }
        }
    }
}
 