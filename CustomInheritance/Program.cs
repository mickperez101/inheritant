using System;

namespace CustomInheritance
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    */

    class Shape
    {
        public double Width;
        public double Height;
        public void ShowDim()
        {
            Console.WriteLine("Width and height are " + Width + " and " + Height);
        }
    
    }
    //Triangle is derived from Shape
    //Drived class or Child Class

    class Triangle:Shape
    {
        public string Style; //style of the triangle
        // Return area of triangle.
        public double Area()
        {
            return Width * Height / 2;
        }

        //Display a Triangle's Style
        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + Style);
        }
    }

    //Driver class which runs the programs
    class Driver
    {
        static void Main()
        {
            Triangle triangle = new Triangle();
            Triangle triangle2 = new Triangle();
            triangle.Width = 4.0;
            triangle.Height = 4.0;
            triangle.Style = "isosceles";
            triangle2.Width = 8.0;
            triangle2.Height = 12.0;
            triangle2.Style = "right";
            Console.WriteLine("Info for t1: ");
            triangle.ShowStyle();
            triangle.ShowDim();
            Console.WriteLine("area is " + triangle.Area());
            Console.WriteLine();
            Console.WriteLine("Info for t2:  ");
            triangle2.ShowStyle();
            triangle2.ShowDim();
            Console.WriteLine("area is " + triangle2.Area());
        }
    }
}
