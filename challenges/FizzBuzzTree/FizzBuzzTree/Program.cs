using System;
using Trees.Classes;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


        }

        public static string FizzBuzzTree(Node tree)
        {
            BinaryTree bt = new BinaryTree();
            bt.PreOrderFizzBuzz(bt.Root);
            Return newTree;
        }
    }
}
