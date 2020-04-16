using System;

namespace ComplexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex(4,3);

            Console.WriteLine($"The addition of the complex number is : {complex.AddTwoComPlex(3,5)}");
            Console.WriteLine($"The subtraction of the complex number is: {complex.SubTwoComPlex(3,5)}");
        }
    }
}
