using System;

namespace FigureArea.Common.Figures
{
    public class Circle : BaseFigure
    {
        public Circle()
            : base("Circle")
        {
            
        }

        public Circle(double radius)
            : this()
        {
            Radius = radius;
        }

        public double Radius { get; set; }
        
        public override double Area()
        {
            if (Radius == 0)
                return 0;
            
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}