using System;
using System.Collections.Generic; 

namespace H1_Opgave1_12
{
    class MainClass
    {
        public static void Main(string[] args)


        {
            //Opgave 1
            Console.WriteLine("Mit navn er Adrian Borgen");

            //Opgave 2
            int tal = 4;
            Console.WriteLine("Dit tal er: {0}", tal);

            //Opgave 3+4
            string navn = "Adrian";
            int age = 21;
            char uniCode = '\u00E5'; //Unicode 'å'

            Console.WriteLine("Dit navn er: "+navn+". Din alder er: "+age+" Dit unicode og tegn er: "+uniCode);

            //Opgave 5
            int value = 10;
            string hej = "Hej med dig";

            Console.WriteLine(hej+" - "+value);

            //Opgave 6
            string age1 = "21";
            int ageNew = Convert.ToInt32(age1);

            Console.WriteLine(age1);

            //Opgave 7
            double tal1 = 4;
            double tal2 = 4.2;

            double sum = tal1 + tal2;
            Console.WriteLine("{0:N2}", sum); 

            //Opgave 8
            Console.WriteLine("Indtast fornavn: ");
            string Fnavn=Console.ReadLine();

            Console.WriteLine("Indtast efternavn: ");
            string Enavn = Console.ReadLine();

            Console.WriteLine("Dit fulde navn er: " + Fnavn+" "+Enavn);

            //Opgave 9
            for (int a = 1; a < 11; a = a + 1)
            {
                Console.WriteLine("{0}: Jeg er bare god til at programmere!", a);
            }

            //Opgave 10
            Console.WriteLine("Indtast et ønsket tal: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int a = 0; a < number; a = a+1)
            {
                Console.WriteLine(a+" En linje af tal");
            }

            //Opgave 11
            Console.WriteLine("Du skal nu indtaste to tal, som du vil lægge sammen.");
            Console.WriteLine("Indtast dit første tal: ");
            double number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast dit andet tal: ");
            double number2 = Convert.ToInt32(Console.ReadLine());

            double result = number1 + number2;
            Console.WriteLine("Dine tal lagt sammen er: " + result);

            //Opgave 12
            Console.Write("Indtast dit navn: ");
            string navnNew = Console.ReadLine();
            int navnlength = (navnNew.Length);

            for (int i = 1; i <= navnlength; i++)
            {
                Console.WriteLine(navnNew);
            }
        }
    }
}
