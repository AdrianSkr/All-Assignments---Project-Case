using System;

namespace Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Public static void <Navn> (string[]args)

            //Public - alle kan tilgå koden
            //Private - kan kun tilgås i samme class
            //Protected - kan kun bruges i samme metode/objekt(?)

            //Void - Ingen data return - return af data
            //Type angives - int 

            string txt = "Hej med dig";
            SimpelMetode();
            SimpelMetode("Hvad så 😂 😂");
            SimpelMetode(txt, 4);
        }

        private static void SimpelMetode(string txt, int v)
        {
            for (int i = 0; i < v;i++)
            {
                SimpelMetode(txt);
            }
        }

        private static void SimpelMetode(string v)
        {
            Console.WriteLine(v);
        }

        private static void SimpelMetode()
        {
            Console.WriteLine("Hej");
        }




    }
}
