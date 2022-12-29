using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProblems
{
    public class VowelorConsonent
    {
        public static void CheckVowelOrConstant()
        {
            char ch;
            Console.WriteLine("Enter any character to check Vowel or Constant");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' ||
                ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is Vowel");
            }
            else
            {
                Console.WriteLine(ch + " is Constant");
            }

        }
    }
}
