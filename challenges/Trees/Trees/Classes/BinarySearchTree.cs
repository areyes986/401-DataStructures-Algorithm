using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    class BinarySearchTree
    {
        public Node Root { get; set; }

        public Node Add(Node root, int value)
        {
            if (root == null)
            {
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

        public bool Contains (int value)
        {
            if (value == Root.Value)
            {
                return true;
            }
            return false;
        }
    }
}
