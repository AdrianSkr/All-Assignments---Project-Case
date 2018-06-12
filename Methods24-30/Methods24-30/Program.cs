using System;

namespace Methods2430
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int sum = SimpelMetodeMinus(8700, 7550); //RETURNERE EN VÆRDI
            Console.WriteLine((sum-55)); 

            int metodeInt = 1337;
            string txt = "ESKETIT";

            SimpelMetode(2, 2); //De to tal vi bruger i vores scope
            SimpelMetode(txt);
            SimpelMetode(metodeInt);

        }

        //Opgave 24
        private static void SimpelMetode(int v1, int v2)
        {
            Console.WriteLine(v1 + v2); //Ligger vores to tal sammen - kan altid blive ændret i vores metode
        }

        //Opgave 25 & 26
        private static void SimpelMetode(string txt)
        {
            Console.WriteLine(txt);
            Console.WriteLine("Vi henter txt data fra vores metode, som udskriver: "+txt);
            Console.WriteLine("Vi kan blive ved "+txt+" med at hente "+txt+" txt data "+txt);
        }

        //Opgave 27
        private static void SimpelMetode(int metodeInt)
        {
            Console.WriteLine(metodeInt); //Udskriver vores int
            Console.WriteLine(metodeInt+" Vi kan udskrive vores int, lige meget hvor vi er i scopet: "+metodeInt);
        }

        //Opgave 28
        private static int SimpelMetodeMinus(int tal1, int tal2) //RETURNERE EN VÆRDI 
        {
            int o = tal1 + tal2;
            return o;
        }


    }
}
