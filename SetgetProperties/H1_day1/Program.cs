using System;
namespace Classoggetset
{
    public class Person
    {
        public string personInformation { get; set; }
        public int personInfo { get; set; }
    }

    class Nisser
    {
        private string mitNavn;
        public string Navn
        {
            get { return mitNavn; }
            set { mitNavn = value; }
        }

        private int minAlder;
        public int Alder
        {
            get { return minAlder; }
            set { minAlder = value; }
        }

        private string minAddress;
        public string Address
        {
            get { return minAddress; }
            set { minAddress = value; }
        }

        public override string ToString()
        {
            return "Nisse: " + Navn + " " + Alder;
        }
    } 

    class Kast
    {
        private int mitNummer;
        public int Nummer
        {
            get { return mitNummer; }
            set { Nummer = value; }
        }

        public override string ToString()
        {
            int number = 0;
            Random rnd = new Random();

            for (int x = 1; x <= 5; x++)
            {
                number = rnd.Next(1, 7);
                Console.WriteLine(number);
            }
            return;

        }
    }
   
    public class Program
    {
        public static void Main()
        {
            //Kast K1 = new Kast {}
            Kast kast1 = new Kast { Nummer = 0 };
            Console.WriteLine(kast1.Nummer);

            Person Fnavn = new Person();
            Person Enavn = new Person();
            Person Address = new Person();
            Person Phone = new Person();

            Fnavn.personInformation = "Abraham";
            Enavn.personInformation = "Lincoln";
            Address.personInformation = "Dead Street 23";

            Phone.personInfo = 123456789;

            Console.WriteLine("Person information: {0}, {1}, {2}", Fnavn.personInformation, Enavn.personInformation, Address.personInformation, Phone.personInfo);

            Fnavn.personInformation = "Gilbert";
            Enavn.personInformation = "Skysauce";
            Address.personInformation = "Himalaya Boulevard 54";

            Phone.personInfo = 12345678;

            Console.WriteLine("Person information: {0}, {1}, {2}", Fnavn.personInformation, Enavn.personInformation, Address.personInformation, Phone.personInfo);

            Nisser nisse1 = new Nisser { Alder = 200, Navn = "Jan Johansen", Address="Vej Nr. 2" };
            Nisser nisse2 = new Nisser { Alder = 150, Navn = "Retard", Address="Vej Nr. 3" };
            Nisser nisse3 = new Nisser { Alder = 100, Navn = "Hello", Address="Vej Nr. 1" };

                //Console.WriteLine("Nisse1 ="+nisse1.Alder+ " "+nisse1.Navn); //Skriver uanset override, såfremt der er data i vores objekt
            Console.WriteLine(nisse1.Navn+nisse1.Alder+nisse1.Address); //Henter data fra vores override 


        }
    }
}
