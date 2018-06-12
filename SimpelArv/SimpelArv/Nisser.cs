using System;
namespace SimpelArv
{
    public class Nisser
    {
        public int Alder { get; set; }
        public string Navn { get; set; }

        public override string ToString()
        {
            return "Nisse: " + Navn + " " + Alder;
        }
    }
}
