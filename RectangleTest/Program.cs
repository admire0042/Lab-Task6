using System;

namespace RectangleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Rectangle rectangle = new Rectangle();


            Console.WriteLine($"The area of rectangle before setting value: { rectangle.AreaOfRectangle }");
            Console.WriteLine($"The perimeter of rectangle before setting: { rectangle.Perimeter }");

            rectangle.Length = 5.2;
            rectangle.Width = 6.0;

            Console.WriteLine($"The area of rectangle after setting value: { rectangle.AreaOfRectangle:F}");
            Console.WriteLine($"The area of perimeter after setting value:{ rectangle.Perimeter }");
        }
    }
}
