using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirst.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// This adds a new node into the binary tree. If the value is less than the root, it adds it to the left child. If greater, to the rightchild
        /// </summary>
        /// <param name="root">the new node</param>
        /// <param name="value">the inputted value</param>
        /// <returns></returns>
        public Node Add(Node root, int value)
        {
            if (root == null)
            {
                root = new Node();
                root.Value = value;
            }
            else if (value < root.Value)
            {
                root.LeftChild = Add(root.LeftChild, value);
            }
            else
            {
                root.RightChild = Add(root.RightChild, value);
            }
            Root = root;
            return Root;
        }

        /// <summary>
        /// This just sees whether or not a node is already inputted into the tree. If the value is in, returns true, if not returns false
        /// </summary>
        /// <param name="value">The search value</param>
        /// <returns></returns>
        public bool Contains(int value)
        {
            if (value == Root.Value)
            {
                return true;
            }
            return false;
        }
    }
}
