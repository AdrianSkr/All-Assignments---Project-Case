using System;

namespace Kasseapparat
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til mit Kasseapparat!");

            Console.WriteLine("Her sælger vi alt fra de sødeste æbler til de lækreste monster!");

            Console.WriteLine("Hvad kunne du tænke dig? ");
            string vareNavn = Console.ReadLine();

            Console.WriteLine("Hvor mange"+vareNavn+" kunne du tænke dig?");
            double vareAntal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Her bestemmer du selv prisen. Hvad skal den være? ");
            double varePris = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skal du have flere vare?");
            string flereVare = Console.ReadLine().ToUpper();

            if(flereVare=="JA")
            {
                Console.WriteLine("Hvad kunne du tænke dig? ");
                string vareNavn2 = Console.ReadLine();

                Console.WriteLine("Hvor mange" + vareNavn2 + " kunne du tænke dig?");
                string vareAntal2 = Console.ReadLine();

                Console.WriteLine("Her bestemmer du selv prisen. Hvad skal den være? ");
                double varePris2 = Convert.ToDouble(Console.ReadLine());
            }

            else if(flereVare=="NEJ")
            {
                double endeligPris = varePris * vareAntal;

                Console.Write("Du har handlet: "+vareNavn);
                Console.Write("Du har á antal: "+vareAntal);
                Console.Write("TIl en samlet pris på: "+endeligPris);

                Console.Write(vareNavn);

            }













        }
    }
}
