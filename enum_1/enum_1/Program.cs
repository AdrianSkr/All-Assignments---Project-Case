using System;

namespace enum_1
{
    class MainClass
    {
        enum Verden {øst, vest, nord, syd}

        public static void Main(string[] args)
        {
            /*
            #region enum

            Verden direction = Verden.nord;

            int x = (int)direction;
            Console.BackgroundColor= ConsoleColor.DarkCyan;

            direction = (Verden)2;

            Console.WriteLine(x);
            Console.WriteLine(direction);

            #endregion
            */

            #region bilInfo
            bil minbil = new bil();
            minbil.mærke = "Volvo";
            minbil.model = "V90";
            minbil.årgang = 2008;

            bil minbil = new bil("ford", "ka", 2014, bil.brændstof.hybrid);
            #endregion

        struct bil
        {
            public string mærke, model;
            public int årgang;
            public enum brændstof { benzin, diesel, hybrid, el }
            private brændstof brændstof;

                public bil (string m1, string m2, int år, brændstof b1)
                {
                mærke = m1;
                model = m2;
                årgang = år;
                brændstof = b1;
                }










        }
    }
}
