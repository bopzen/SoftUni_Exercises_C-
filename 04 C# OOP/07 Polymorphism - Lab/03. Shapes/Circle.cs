﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Radius 
        { 
            get { return radius; } 
            set { this.radius = value; }    
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
