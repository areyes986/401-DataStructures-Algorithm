using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public int[] PreOrder()
        {
            return Root.Value;
            if (Root.LeftChild != null && Root.RightChild != null)
            {
                PreOrder(Root.LeftChild);
                PreOrder(Root.RightChild);
            }
           



        }
    }
}
