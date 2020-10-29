using System;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class TSquare
    {
        public double sideOfSquare { get; set; }

        public TSquare(double s)
        {
            this.sideOfSquare = s;
        }

        public TSquare(TSquare b)
        {
            this.sideOfSquare = b.sideOfSquare;
        }

        public TSquare()
        {

        }

        public override string ToString()
        {
            return " сторона квадрата " + sideOfSquare;
        }

        public virtual double Perimiter()
        {
            return 4 * sideOfSquare;
        }

        public virtual double Area()
        {
            return sideOfSquare * sideOfSquare;
        }

        public static bool operator >(TSquare a, TSquare b)
        {
            return a.sideOfSquare > b.sideOfSquare;
        }

        public static bool operator <(TSquare a, TSquare b)
        {
            return a.sideOfSquare < b.sideOfSquare;
        }

        public static TSquare operator +(TSquare a, TSquare b)
        {
            TSquare e = new TSquare();

            e.sideOfSquare = a.sideOfSquare + b.sideOfSquare;
            return e;
        }

        public static TSquare operator -(TSquare a, TSquare b)
        {
            TSquare e = new TSquare();

            e.sideOfSquare = a.sideOfSquare - b.sideOfSquare;
            return e;
        }

        public static double operator *(TSquare a, double b)
        {
            return a.sideOfSquare * b;
        }


    }

    class Tcube : TSquare
    {

        public Tcube(double s) : base(s)
        {
            
        }

        public Tcube() : base()
        {

        }

        public Tcube(Tcube b) : base (b)
        { }
        
           
        

        public override double Area()
        {
            return 6 * Math.Pow(sideOfSquare, 2);
        }

        public override double Perimiter()
        {
            return 12 * sideOfSquare;
        }


        public override string ToString()
        {
            return "сторона куба " + sideOfSquare;
        }

        public double Volume()
        {
            return Math.Pow(sideOfSquare, 3);
        }
    }
}
