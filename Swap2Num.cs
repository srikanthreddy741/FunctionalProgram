using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProblems
{
    public class Swap2Num
    {
        public static void SwappingNumbers()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before Swap a=" + a + " b = " + b);

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After Swap a = " + a + " b = " + b);
        }
    }
}