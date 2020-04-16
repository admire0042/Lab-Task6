using System;

namespace RationalTest
{
    class Rational
    {
        private int numerator;
        private int denominator;

        public Rational(int num = 1, int den =2)
        {
            numerator = num;
            denominator = den;
        }

        public int AddtwoRational(int numerate, int denominate){
                
               int nume = numerator*denominate + numerate*denominator;
               int deno = denominator * denominate;
        }
    }
}
