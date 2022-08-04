using System;
using System.Text.RegularExpressions;

namespace CSharpStudio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double milesPerGallon;
            string input;
            const string pattern = @"^\d+\.*\d*$|^\.\d+$";
            Regex expression = new Regex(pattern);

            do
            {
                Console.Write("Enter the radius of a circle: ");
                input = Console.ReadLine();
            } while (!expression.IsMatch(input));

            radius = double.Parse(input);
            Circle circle = new Circle(radius);
            Console.WriteLine($"The circumference of the circle is {circle.circumference}.\nThe area of the circle is {circle.area}.");

            do
            {
                Console.Write("Enter your car's miles per gallon: ");
                input = Console.ReadLine();
            } while (!expression.IsMatch(input));

            milesPerGallon = double.Parse(input);

            Console.WriteLine($"It would take your car {GetMpgAroundCircle(circle, milesPerGallon)} gallons of gas to travel the circumference of the circle.");
        }
        public static double GetMpgAroundCircle(Circle circ, double mpg)
        {
            return (mpg == 0d ? 0d : circ.circumference / mpg);
        }
    }
}
