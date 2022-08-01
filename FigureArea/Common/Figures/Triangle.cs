using System;

namespace FigureArea.Common.Figures
{
    public class Triangle : BaseFigure
    {
        public Triangle()
            : base("Triangle")
        {
            
        }

        public Triangle(double a, double b, double c)
            : this()
        {
            A = a;
            B = b;
            C = c;
        }
        
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public bool IsRight
        {
            get
            {
                if (A == 0 || B == 0 || C == 0)
                    return false;
                
                if (A >= B && A >= C)
                    return Math.Pow(A, 2) - (Math.Pow(B, 2) + Math.Pow(C, 2)) == 0;
                
                if (B >= A && B >= C)
                    return Math.Pow(B, 2) - (Math.Pow(A, 2) + Math.Pow(C, 2)) == 0;
                
                if (C >= A && C >= B)
                    return Math.Pow(C, 2) - (Math.Pow(B, 2) + Math.Pow(A, 2)) == 0;

                return false;
            }
        }

        public override double Area()
        {
            if (A == 0 || B == 0 || C == 0)
                return 0;
            
            var p = (A + B + C) / 2;
            
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}