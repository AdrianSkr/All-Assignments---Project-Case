using System;

namespace program
{
    class program
    {
        public static void Main(string[] args)
        {
            Person Obama = new Person();
            Obama.myAlder = 100;
            Console.WriteLine("Han er "+Obama.myAlder+" år gammel.");
            Obama.myNavn = "Barack Obama";
            Console.WriteLine("Han hedder: "+Obama.myNavn);

        }
    }
}
