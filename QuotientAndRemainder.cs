using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProblems
{
    public class QuotientAndRemainder
    {
        public static void CalculateQuotientAndRemainder()
        {
            int dividend = 80, divisor = 8;
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend : {0}, Divisor : {1} ", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
