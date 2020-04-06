using System;
using Trees.Classes;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TryingPreOrder();
        }

        public static void TryingPreOrder()
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree();
            bt.Root.Value = 6;
            bst.Add(bt.Root, 3);
            bst.Add(bt.Root, 4);
            bst.Add(bt.Root, 5);

            int[] array = bt.PreOrder(bt.Root);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
