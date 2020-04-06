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

        List<int> ListNode = new List<int>();
        public int[] PreOrder(Node root)
        {

            ListNode.Add(root.Value);

            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                PreOrder(root.RightChild);
            }
            return ListNode.ToArray();

        }

        public int[] InOrder(Node root)
        {
            if (root.LeftChild != null)
            {
                InOrder(root.LeftChild);
            }
            ListNode.Add(root.Value);
            if(root.RightChild != null)
            {
                InOrder(root.RightChild);
            }
            return ListNode.ToArray();
        }

        public int[] PostOrder(Node root)
        {
            if (root.LeftChild != null)
            {
                PostOrder(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                PostOrder(root.RightChild);
            }
            ListNode.Add(root.Value);
            return ListNode.ToArray();
        }
    }
}
