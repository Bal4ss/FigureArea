using System;

namespace FigureArea.Common.Figures
{
    public class Circle : BaseFigure
    {
        private double _radius;
        
        public Circle()
            : base("Circle")
        {
            
        }

        public Circle(double radius)
            : this()
        {
            Radius = radius;
        }

        public double Radius
        {
            get => _radius;
            set => _radius = value >= 0 ? value : -value;
        }
        
        public override double Area()
        {
            if (Radius == 0)
                return 0;
            
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}