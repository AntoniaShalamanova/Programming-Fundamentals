using System;
using System.Linq;
using System.Collections.Generic;

namespace P6RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstRectangle = ReadARectangle();
            Rectangle secondRectangle = ReadARectangle();

            if (secondRectangle.IsInside(firstRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        private static Rectangle ReadARectangle()
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Rectangle rectangle = new Rectangle();
            rectangle.Left = input[0];
            rectangle.Top = input[1];
            rectangle.Width = input[2];
            rectangle.Height = input[3];

            return rectangle;
        }
    }

    class Rectangle
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double Right { get { return Left + Width; } }
        public double Bottom { get { return Top + Height; } }

        public bool IsInside(Rectangle rectangle)
        {
            if (rectangle.Left >= Left &&  rectangle.Right <= Right && rectangle.Top >= Top && rectangle.Bottom <= Bottom)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
