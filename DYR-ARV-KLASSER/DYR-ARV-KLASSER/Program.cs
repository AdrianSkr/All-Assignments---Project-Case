using System;

namespace DYRARVKLASSER
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Lærer l1 = new Lærer("John", "Cena");
            //Elev e1 = new Elev("Hara", "Mbe", "1337");

            //Console.WriteLine(l1.FuldtNavn());
            //Console.WriteLine(e1.FuldtNavn());
            //Console.WriteLine(l1.FuldtNavn());
            //Console.WriteLine(e1.FuldtNavn());

            Dog D1 = new Dog("Bigdog", "12", "Brazil");
            Cat C1 = new Cat("Tigermancat", "42", "Norway'nt", "Meooooooooow");
            Fish F1 = new Fish("Sea Linguini", "124", "Sealand");
            Bird B1 = new Bird("Eaglebird", "4", "Afrika'nt", "Pipipipipipipipipip");

            Console.WriteLine(D1.FuldDyreInfo());
            Console.WriteLine(C1.FuldDyreInfo());
            Console.WriteLine(F1.FuldDyreInfo());
            Console.WriteLine(B1.FuldDyreInfo());

        }
    }
}
