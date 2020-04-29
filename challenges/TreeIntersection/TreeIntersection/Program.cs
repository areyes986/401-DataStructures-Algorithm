using System;
using Trees.Classes;

namespace TreeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] TreeIntersection(BinaryTree tree1, BinaryTree tree2)
        {

            int[] array1 = tree1.PreOrder(tree1.Root);
            int[] array2 = tree2.PreOrder(tree2.Root);

            int counter = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    counter++;
                }
            }

            int[] newArr = new int[counter];

            counter = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    counter++;
                }
            }
            return newArr;

        }
    }
}
