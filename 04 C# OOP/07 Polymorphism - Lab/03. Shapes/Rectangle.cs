using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public double Height 
        {
            get { return height; } 
            set { this.height = value; }    
        }
        public double Width 
        { 
            get { return width; }
            set { this.width = value; } 
        }
        public override double CalculatePerimeter()
        {
            return 2 * (this.Height + this.Width);
        }
        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }
        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
    
}
