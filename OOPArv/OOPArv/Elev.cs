using System;
namespace OOPArv
{
    public class Elev:Person
    {
        public string StudiekortID { get; set; }

        //default constructor
        public Elev(string Fnavn, string Enavn, string skortID):base(Fnavn, Enavn)
        {
            this.StudiekortID = skortID;
        }
        //Overrider virtual method in base class 'fuldtnavn'
        public override string FuldtNavn()
        {
            return base.FuldtNavn() + " (" + StudiekortID + ")";
        }
    }
}
