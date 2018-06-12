using System;
namespace AbstractClass
{
    class MyImplementedClass : myAbstractClass
    {
        //Constructor receives two arguments and puts them into the base class
        public MyImplementedClass(string name, int alder) : base(name, alder)
        {
        }

        public override string Birthday()
        {
            Alder = Alder + 1;
            return "Tillykke, u r øgli" + Name + " u r more ugly at the age of "+ Alder+ " retard";
        }
    }
}
