using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
    public class Circle
    {
        public double radius;
        public double CalculateArea()
        {
            int x = 10;
            x = 20;
            return this.radius * this.radius * Math.PI;
        }
        public static void Main2()
        {
            Circle c = new Circle();
            Circle c2 = new Circle();
            c.radius = 10;
            double area = c.CalculateArea();
            double area2 = c2.CalculateArea();
        }

    }
}
