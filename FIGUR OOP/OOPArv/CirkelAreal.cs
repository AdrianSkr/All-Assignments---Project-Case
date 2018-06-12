using System;
namespace OOPArv
{
    public class Cirkel:Figur
    {
        public double A { get; set; }

        public Cirkel(double R)
        {
            //this.Areal = ArealResult;
            this.R = R;
        }

        public string Areal()
        {
            A = (R*R) * Math.PI;
            return "Cirkel: Areal= " + Math.Round(A, 2);
        }
    }
}
