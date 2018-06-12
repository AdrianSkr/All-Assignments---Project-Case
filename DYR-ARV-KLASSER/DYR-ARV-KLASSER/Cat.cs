using System;
namespace DYRARVKLASSER
{
    public class Cat:Kæledyr
    {
        public string Meow { get; set; }

        //default constructor
        public Cat(string Race, string Alder, string Afstammer, string kattenSiger) : base(Race, Alder, Afstammer)
        {
            this.Meow = kattenSiger;
        }

        //Overrider virtual method in base class 'fuldtnavn'
        public override string FuldDyreInfo()
        {
            return base.FuldDyreInfo() + " (" + Meow + ")";
        }
    }
}
