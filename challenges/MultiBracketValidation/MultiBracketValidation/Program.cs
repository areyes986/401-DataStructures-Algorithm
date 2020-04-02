using MultiBracketValidation.Classes;
using System;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string brackets = "{}[]()";
            MultiBracketValidation(brackets);
        }

        public static string MultiBracketValidation(string input)
        {

            char [] charArray = input.ToCharArray();
            Stack stack = new Stack();

            for (int i = 0; i < charArray.Length; i++)
            {
                string charToString = new string(charArray);
                if (charToString == "{" || 
                    charToString == "}" ||
                    charToString == "[" ||
                    charToString == "]" ||
                    charToString == "(" ||
                    charToString == ")")
                {
                    stack.Push(charToString);
                }

            }

        }
    }
}
