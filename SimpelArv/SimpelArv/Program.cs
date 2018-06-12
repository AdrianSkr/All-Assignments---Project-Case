using System;

namespace SimpelArv
{
    class ArvClass
    {
        public static void Main(string[] args)
        {
            Nisser nisse1 = new Nisser { Navn = "Nissemanden", Alder = 21 };

            Console.WriteLine(nisse1);

            ArveNisse nisse2 = new ArveNisse { Navn = "Dwayne", Alder = 45, Nissemand="skønt" };
            Console.WriteLine(nisse2);

        }
    }
}
