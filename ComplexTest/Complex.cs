using System;

namespace ComplexTest
{
    class Complex
    {
        private double a;
        private double b;

        public Complex(double aa = 2, double bb= 3)
        {
            a = aa;
            b = bb;
        }

        public string AddTwoComPlex(double A, double B)
        {
            double ans1 = a + A;
            double ans2 = b + B;
            return $"({ans1}, {ans2})";

        }
        public string SubTwoComPlex(double A, double B)
        {
            double ans1 = a - A;
            double ans2 = b - B;
            return $"({ans1},{ans2})";

        }
    }
}
