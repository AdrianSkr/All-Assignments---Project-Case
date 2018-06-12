using System;
namespace OOPArv
{
    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string CPRnummer {get; set; }
        //Default constructor

        public Person()
        {
            
        }

        public Person(string Fnavn, string Enavn)
        {
            this.Fornavn = Fnavn;
            this.Efternavn = Enavn;
        }

        //Metode der kan overrides i nedarvede classer
        public virtual string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }
}
