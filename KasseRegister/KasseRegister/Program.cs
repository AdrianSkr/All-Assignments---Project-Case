using System;
using System.Collections.Generic;
using System.IO;

namespace Kasseapparat
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string flereVare = "";
            List<Vare> minvareliste = new List<Vare>();
            Vare nyVare = new Vare();
            double ialt = 0;
            double returpenge = 0;

            string[] lines = { nyVare.vareNavn };

            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            do
            {
                Console.WriteLine("Indtast vare: ");
                nyVare.vareNavn = Console.ReadLine();
                Console.WriteLine("Indtast antal: ");
                nyVare.vareAntal = int.Parse(Console.ReadLine());
                Console.WriteLine("Indtast pris pr. stk.: ");
                nyVare.varePris = float.Parse(Console.ReadLine());
                Console.WriteLine("Flere vare? ");
                flereVare = Console.ReadLine().ToUpper();
                minvareliste.Add(nyVare);

                if (flereVare != "JA")
                {
                    Console.WriteLine("*** KVITTERING ***");
                    if (nyVare.vareAntal < 4)
                    {
                        foreach (Vare nyvare in minvareliste)
                        {
                            double varebelob = nyvare.varePris * nyvare.vareAntal;
                            ialt = ialt + varebelob;

                            Console.Write(nyvare.vareNavn + " - antal: " + nyvare.vareAntal + " - pris i alt for alle á enhed: " + (nyvare.varePris * nyvare.vareAntal) + " kr. ");
                        }

                        Console.WriteLine("Du har købt for: " + ialt);
                        Console.WriteLine("Hvor mange penge betaler du med? ");
                        Console.Write("");
                        int betaling = Convert.ToInt32(Console.ReadLine());

                        returpenge = betaling - ialt;

                        Console.WriteLine("Du får " + returpenge + " kr. tilbage.");

                        using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "WriteLines.txt")))
                        {
                            outputFile.WriteLine("***KVITTERING***");
                            foreach (Vare nyvare in minvareliste)
                            {
                                outputFile.WriteLine();
                                outputFile.WriteLine("Du har handlet: " + nyvare.vareAntal + " stk. " + nyvare.vareNavn + ". Til en pris af: " + nyvare.varePris + " kr. pr. stk.");
                                outputFile.WriteLine("Pris for alle: " + (nyvare.vareAntal * nyvare.varePris)+ ".");
                            }
                            outputFile.WriteLine(" ");
                            outputFile.WriteLine("Samlet pris er: " + ialt + ".");
                        }
                    }
                    else if (nyVare.vareAntal >=5 && nyVare.vareAntal <= 9)
                    {
                        foreach (Vare nyvare in minvareliste)
                        {
                            double varebelob = nyvare.varePris * nyvare.vareAntal;
                            ialt = ialt + varebelob;

                            Console.Write(nyvare.vareNavn + " - antal: " + nyvare.vareAntal + " - pris i alt for alle á enhed: " + (nyvare.varePris * nyvare.vareAntal) + " kr. ");
                        }

                        Console.WriteLine("Du har købt for: " + ialt * 0.95+" (5% rabat inkluderet)");
                        Console.WriteLine("Hvor mange penge betaler du med? ");
                        Console.Write("");
                        int betaling = Convert.ToInt32(Console.ReadLine());

                        returpenge = betaling - ialt * 0.95;

                        Console.WriteLine("Du får " + returpenge + " kr. tilbage.");

                        using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "WriteLines.txt")))
                        {
                            outputFile.WriteLine("***KVITTERING***");
                            foreach (Vare nyvare in minvareliste)
                            {
                                outputFile.WriteLine();
                                outputFile.WriteLine("Du har handlet: " + nyvare.vareAntal + " stk. " + nyvare.vareNavn + ". Til en pris af: " + nyvare.varePris + " kr. pr. stk.");
                                outputFile.WriteLine("Pris for alle: " + (nyvare.vareAntal * nyvare.varePris) * 0.95 + ". Dette er med 5% rabat.");
                            }
                            outputFile.WriteLine(" ");
                            outputFile.WriteLine("Samlet pris er: " + ialt * 0.95 + ". Dette er med 5% rabat.");
                        }
                    }
                    else if (nyVare.vareAntal >= 10)
                    {
                        foreach (Vare nyvare in minvareliste)
                        {
                            double varebelob = nyvare.varePris * nyvare.vareAntal;
                            ialt = ialt + varebelob;

                            Console.Write(nyvare.vareNavn + " - antal: " + nyvare.vareAntal + " - pris i alt for alle á enhed: " + (nyvare.varePris * nyvare.vareAntal) + " kr. ");
                        }

                        Console.WriteLine("Du har købt for: " + ialt * 0.90+" (10% rabat inkluderet)");
                        Console.WriteLine("Hvor mange penge betaler du med? ");
                        Console.Write("");
                        int betaling = Convert.ToInt32(Console.ReadLine());

                        returpenge = betaling - ialt * 0.90;

                        Console.WriteLine("Du får " + returpenge + " kr. tilbage.");

                        using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "WriteLines.txt")))
                        {
                            outputFile.WriteLine("***KVITTERING***");
                            foreach (Vare nyvare in minvareliste)
                            {
                                outputFile.WriteLine();
                                outputFile.WriteLine("Du har handlet: " + nyvare.vareAntal + " stk. " + nyvare.vareNavn + ". Til en pris af: " + nyvare.varePris + " kr. pr. stk.");
                                outputFile.WriteLine("Pris for alle: "+(nyvare.vareAntal*nyvare.varePris)*0.90+". Dette er med 10% rabat.");
                            }
                            outputFile.WriteLine(" ");
                            outputFile.WriteLine("Samlet pris er: " + ialt * 0.90+". Dette er med 10% rabat.");     

                        }
                    }
                }

            } while (flereVare == "ja" || flereVare == "JA");
        }

            struct Vare
        {
            public string vareNavn;
            public int vareAntal;
            public float varePris;
        }
    }
}