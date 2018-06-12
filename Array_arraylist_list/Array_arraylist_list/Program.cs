using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_arraylist_list
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Opgave 8.1
            string[] mdrNavn = new string[13]; //Tomt array med 13 pladser/elementer
            //string mdr;

            mdrNavn[0] = "Januar"; //Udfylder array data
            mdrNavn[1] = "Februar";
            mdrNavn[2] = "Marts";
            mdrNavn[3] = "April";
            mdrNavn[4] = "Maj";
            mdrNavn[5] = "Juni";
            mdrNavn[6] = "Juli";
            mdrNavn[7] = "August";
            mdrNavn[8] = "September";
            mdrNavn[9] = "Oktober";
            mdrNavn[10] = "November";
            mdrNavn[11] = "December";
            mdrNavn[12] = "Bichat";

            Console.WriteLine("Dit array er: "+mdrNavn.Length+" langt.");
            Console.WriteLine(" ");

            //mdr = mdrNavn[1]; 
            for (int i = 0; i < mdrNavn.Length; i++)
            {
                Console.WriteLine("Måned nr {0} er: {1}",i+1 , mdrNavn[i]);
            }
            Console.WriteLine(" ");

            //Opgave 8.3
            var plus4list = new List<int>();
            Console.WriteLine("Følgende udskriver hvis mdr. er større end 4 bogstaver: ");
            for (int i = 0; i < mdrNavn.Length; i++)
                if(mdrNavn[i].Length>(4))
                {
                    Console.WriteLine(mdrNavn[i]);
                    plus4list.Add(mdrNavn[i]);
                }
            Console.WriteLine(" ");

            Console.WriteLine("Følgende udskriver fra a til z");
            var sortedmdr = mdrNavn.OrderBy(a => a);
            foreach (var item in sortedmdr)
            {
                Console.WriteLine(item);
            }





                    //Opgave 8.2
            
            for (int i = 0; i < mdrNavn.Length; i++)
                if (mdrNavn[i].Contains("a"))
                
            {
                Console.WriteLine(mdrNavn[i]);
            }
                else if (mdrNavn[i].Contains("A"))
            {
                Console.WriteLine(mdrNavn[i]);
                }
                



















            //if (mdrNavn.Contains("a"))
            //{
            //    Console.WriteLine(mdrNavn);
            //}

            //Console.WriteLine(mdrNavn.Contains("Januar"));

            /*
            int Antal;
            Console.WriteLine("Hvor mange tal skal gemmes i arrayet?");
            Antal = Convert.ToInt32(Console.ReadLine());

            int[] MineTal = new int[Antal];
            for (int i = 0; i < Antal; i++)
            {
                Console.WriteLine("skriv et tal");
                MineTal[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int tal in MineTal)
            {
                Console.WriteLine("......................");
                Console.WriteLine(tal);
            }

            int Total = MineTal.Sum();
            int StoersteTal = MineTal.Max();
            int MindsteTal = MineTal.Min();
            double Gennemsnit = MineTal.Average();

            Console.WriteLine("Det største tal er {0}", StoersteTal);
            Console.WriteLine("Det mindste tal er {0}", MindsteTal);
            Console.WriteLine("summen af talene i arrayet er {0}", Total);
            Console.WriteLine("gennemsnittet for talene i arrayet er {0:N2}", Gennemsnit);
            Console.WriteLine();
            */

            /*
            string[] strArray = new string[7]; //Tomt array med 7 pladser/elementer
            string[] strArray1 = {"a", "b", "c"}; //Udfyldt array med 3 pladser/elementer

            Console.WriteLine(strArray.Length); //Udskriver længden på vores array

            strArray[0] = "Hej"; //Udfylder array data
            strArray[1] = "med";
            strArray[2] = "dig!";

            for (int i = 0; i < strArray1.Length; i++)
            {
                Console.WriteLine(strArray1[i]);
                //Console.WriteLine(strArray[i]);
            }
            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }
            */


        }
    }
}
