using System;

namespace Proj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create class Rectangle with requiered fields and methods");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Enter the data of rectangle: ");
            Console.Write("length = ");
            double s1 = double.Parse(Console.ReadLine());
            Console.Write("width = ");
            double s2 = double.Parse(Console.ReadLine());
            Rectangle blackrec = new Rectangle(s1, s2);
            blackrec.AreaCalculator();
            blackrec.PerimeterCalculator();
            Console.WriteLine($"Area of rectangle :  {blackrec.GetArea()}");
            Console.WriteLine($"Perimeter of rectangle :  {blackrec.GetPerimeter()}");
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

            public double GetArea()
            {
                return this.area;
            }
            public double GetPerimeter()
            {
                return this.perimeter;
            }
        }
    }
}
