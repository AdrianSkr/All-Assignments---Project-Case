using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Onsdag2305Opgave7._3Og7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            String navn = "hans chr jensen andersen";
            int aktuel_index = 0;

            //Løsning vha. IndexOf og LastIndexOff
            if (aktuel_index == 0)
            {
                navn = navn.Substring(aktuel_index, 1).ToUpper() + navn.Substring(aktuel_index + 1);
            }

            aktuel_index = navn.IndexOf(" ");

            while (navn.LastIndexOf(" ") >= aktuel_index)
            {

                if (aktuel_index < navn.LastIndexOf(" "))
                {
                    navn = navn.Substring(0, aktuel_index + 1) + navn.Substring(aktuel_index + 1, 1).ToUpper() + navn.Substring(aktuel_index + 2);
                    aktuel_index = navn.IndexOf(" ", aktuel_index + 1);
                }
                else
                {
                    navn = navn.Substring(0, aktuel_index + 1) + navn.Substring(aktuel_index + 1, 1).ToUpper() + navn.Substring(aktuel_index + 2); //, navn.Length - 1);
                    aktuel_index = navn.LastIndexOf(" ") + 1;
                }

            }
            Console.WriteLine(navn);

            //Løsning med array og foreach
            navn = navn.ToLower();
            string[] navnArr = navn.Split(' ');
            string nytNavn = "";

            foreach (string item in navnArr)
            {
                nytNavn += item.Substring(0, 1).ToUpper() + item.Substring(1).ToLower();
                nytNavn += " ";
            }
            Console.WriteLine(nytNavn);

            //Løsning med CultureInfo og Globalization
            string name = "hans ChriStian kurT hansen"; //Variabel 
            string uppercased = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
            Console.WriteLine(uppercased);

            Console.ReadKey();
        }
    }
}
