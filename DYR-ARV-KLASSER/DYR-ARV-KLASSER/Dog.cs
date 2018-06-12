using System;
namespace DYRARVKLASSER
{
    public class Dog:Kæledyr
    {
        public string Bark { get; set; }
        public Dog(string Race, string Alder, string Afstammer) : base(Race, Alder, Afstammer)
        {

        }
    }
}
