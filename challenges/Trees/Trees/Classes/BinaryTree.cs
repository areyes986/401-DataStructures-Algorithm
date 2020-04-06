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

        /// <summary>
        /// This has a preOrder traversal which means it traverses from the root to left to right. 
        /// </summary>
        /// <param name="root">the trees root</param>
        /// <returns>the values in an array</returns>
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
        /// <summary>
        /// InOrder traverses from left to root to right
        /// </summary>
        /// <param name="root">the trees root</param>
        /// <returns>the int array</returns>
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

        /// <summary>
        /// This traverses right left to right to root.
        /// </summary>
        /// <param name="root">the trees root</param>
        /// <returns>the value int array</returns>
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
