using System;
namespace AbstractClass
{
    abstract class myAbstractClass
    {
        private string _Name;
        private int _Alder; 

        public myAbstractClass(string name, int alder)
        {
            Name = name;
            Alder = alder; 
        }

        public int Alder
        {
            get { return _Alder; }
            set { _Alder =value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        abstract public string Birthday();

    }
}
