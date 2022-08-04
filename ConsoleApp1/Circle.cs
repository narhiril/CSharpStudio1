using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudio1
{
    public class Circle
    {
        const double pi = 3.141592654d;
        public double radius;
        public double circumference;
        public double area;

        public Circle(double rad)
        {
            radius = rad;
            circumference = 2d * pi * radius;
            area = pi * Math.Pow(radius, 2d);
        }

    }
}
