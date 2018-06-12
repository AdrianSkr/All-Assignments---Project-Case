using System;
namespace OOPArv
{
    public class Lærer:Person
    {
        public string Bankkontonr { get; set; }
        public Lærer(string Fnavn, string Enavn) : base(Fnavn, Enavn)
        {
            
        }
    }
}
