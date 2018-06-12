using System;
namespace DYRARVKLASSER
{
    public class Kæledyr
    {
        public string Race { get; set; }
        public string Alder { get; set; }
        public string Afstammer { get; set; }
            
        //Default constructor

        public Kæledyr()
            {

            }

        public Kæledyr(string Race, string Alder, string Afstammer)
            {
            this.Race = Race;
            this.Afstammer = Afstammer; 
            this.Alder = Alder; 
            }

            //Metode der kan overrides i nedarvede classer
            public virtual string FuldDyreInfo()
            {
            return Race + " " + Alder + " "+ Afstammer;
            }
    }
}
