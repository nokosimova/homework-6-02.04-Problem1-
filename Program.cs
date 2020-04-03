using System;

namespace Proj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the data of rectangle: ");
            Console.Write("length = ");
            double s1 = double.Parse(Console.ReadLine());
            Console.Write("width = ");
            double s2 = double.Parse(Console.ReadLine());

        }

        class Rectangle
        {
            public double side1{ get; set;}
            public double side2{ get; set;}

            public double area{ get; set;}
            public double perimeter{ get; set;}
            public Rectangle(double s1, double s2) 
            {
                this.side1 = s1;
                this.side2 = s2;
            }
            public double AreaCalculator()
            {
                area = this.side1 * this.side2;
                return area;
            }
            public double PerimeterCalculator()
            {
                perimeter = 2* (this.side1 + this.side2);
                return perimeter;
            }

        }
    }
}
