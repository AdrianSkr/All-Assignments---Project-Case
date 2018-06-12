using System;

namespace OOPArv
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Lærer l1 = new Lærer("John", "Cena");
            Elev e1 = new Elev("Hara", "Mbe", "1337");

            Console.WriteLine(l1.FuldtNavn());
            Console.WriteLine(e1.FuldtNavn());


        }
    }
}
