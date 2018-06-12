using System;
namespace DYRARVKLASSER
{
    public class Bird:Kæledyr
    {
        public string Pip { get; set; }

        //default constructor
        public Bird(string Race, string Alder, string Afstammer, string fuglenSynger) : base(Race, Alder, Afstammer)
        {
            this.Pip = fuglenSynger;
        }

        //Overrider virtual method in base class 'fuldtnavn'
        public override string FuldDyreInfo()
        {
            return base.FuldDyreInfo() + " (" + Pip + ")";
        }
    }
}
