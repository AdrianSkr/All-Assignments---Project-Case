using System;

namespace Opgave13_H1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            //Opgave 13
            Console.WriteLine("Indtast din alder: ");
            int alder = Convert.ToInt32(Console.ReadLine());

            int pensionAlder = 70;
            int result = pensionAlder-alder;

            if (alder > 50 && alder<70) 
            {
                Console.WriteLine("Du er over 50 år.");
                Console.WriteLine("Du er {0} år gammel", alder);
                Console.WriteLine("Du kan gå på pension om: "+result+" år.");
            }
            else if(alder>20 && alder<50)
            {
                Console.WriteLine("Du er imellem 20 og 50 år.");
                Console.WriteLine("Du er {0} år gammel", alder);
                Console.WriteLine("Du kan gå på pension om: "+result+" år.");
            }

            else if (alder<20)
            {
                Console.WriteLine("Du er under 20 år.");
                Console.WriteLine("Du er kun {0} år gammel", alder);
                Console.WriteLine("Bare glem det!!!!!!");
            }
            else if (alder>70)
            {
                Console.WriteLine("Desværre, du er allerede på pension.");
                Console.WriteLine("Du kradser af om 10 år, højst sandsynligt!");
            }
            */

            /*
            //Opgave 14
            string brugernavn = "jensen123";
            string password = "retard";

            Console.Write("Indtast venligst brugernavn: ");
            string inputbrugernavn = Console.ReadLine();

            Console.Write("Indtast venligst password: ");
            string inputpassword = Console.ReadLine();

            if (brugernavn==inputbrugernavn && password==inputpassword)
            {
                Console.WriteLine("Velkommen");
                Console.WriteLine("Dit login er rigtigt");
            }
            else 
            {
                Console.WriteLine("ur mum gaye");
            }
            */

            //Opgave 15
            int tal1 = 13;

            Console.Write("Indtast venligst et tal, 0-100: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            if (tal2==tal1)
            {
                Console.WriteLine("Congratulations");
                Console.WriteLine("Du vandt - klap dig selv på skulderen.");
            }
            else if (tal2 > tal1)
            {
                Console.WriteLine("Du er en taber og kan ikke gætte rigtigt.");
                Console.WriteLine("forskellen mellem {0} og {1} er {2}", tal1, tal2, (tal2-tal1));
            }
            else if (tal1 > tal2)
            {
                Console.WriteLine("Du er en taber og kan ikke gætte rigtigt.");
                Console.WriteLine("forskellen mellem {0} og {1} er {2}", tal1, tal2, (tal1 - tal2));
            }

        }
    }
}
