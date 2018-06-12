using System;
namespace OOPArv
{
    class Firkant:Figur
    {
        public double A { get; set; }

        public Firkant(double L, double W)
        {
            //this.Areal = ArealResult;
            this.L = L;
            this.W = W;
        }

        public string Areal()
        {
            A = L * W;
            return "Firkant: Areal= " + Math.Round(A, 2);
        }
    }
}
