using Hashtables.Classes;
using System;

namespace RepeatedWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RepeatedWord("My dog's name is Mochi, but my first dog was named Kudo");
        }

        public static string RepeatedWord(string longString)
        {
            string replacedString = longString.Replace(", ", " ");

            string [] splittedString = replacedString.Split(" ");

            Hashtable hashtable = new Hashtable();

            for (int i = 0; i < splittedString.Length ; i++)
            {
                if (hashtable.Contains(splittedString[i]))
                {
                    return splittedString[i];
                }
                hashtable.Add(splittedString[i], " ");
            }

            return " ";
        }
    }
}
