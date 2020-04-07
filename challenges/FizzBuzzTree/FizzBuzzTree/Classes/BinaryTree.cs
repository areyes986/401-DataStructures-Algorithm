using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = new Node();
        }


        public void PreOrderFizzBuzz(Node root)
        {

            if (root.Value % 3 == 0 && root.Value % 5 == 0)
            {
                root.StringValue = "FizzBuzz";
            }
            if (root.Value % 3 == 0)
            {
                root.StringValue = "Fizz";
            }
            if (root.Value % 5 == 0)
            {
                root.StringValue = "Buzz";
            }
            else
            {
                root.Value = root.Value;
            }

            PreOrderFizzBuzz(root.LeftChild);
            PreOrderFizzBuzz(root.RightChild);
        }



    }
}
