using System;
namespace SimpelArv
{
    public class ArveNisse : Nisser
    {
        private string _myNissemand;
        public string Nissemand

        {
            get { return _myNissemand; }
            set{
                if (value == "grimt")
                    _myNissemand = value;
                else
                    _myNissemand = "skønt";
            }
        }
        public override string ToString()
        {
            return base.ToString()+" Giga autism " + Nissemand;
        }
    }
}
