namespace FigureArea.Common
{
    public abstract class BaseFigure : IFigure
    {
        protected BaseFigure()
        {
            
        }
        
        protected BaseFigure(string name)
            : this()
        {
            Name = name;
        }
        
        public string Name { get; }
        public abstract double Area();
    }
}