using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfOddBinaryTree.Classes
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
            if (root.RightChild != null)
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

        /// <summary>
        /// This method uses the Breadth First traversal to go through all the nodes of the tree and a tracker is initialed to keep track if the value is higher than the tracker, the tracker will equal the value
        /// </summary>
        /// <param name="tree">The binary tree</param>
        /// <returns>the highest value</returns>
        public int SumofOddNum(BinarySearchTree tree)
        {
            Queue queue = new Queue();
            int tracker = 0;

            queue.Enqueue(tree.Root);

            while (queue.Front != null)
            {
                Node Front = queue.Dequeue();

                if (Front.Value % 2 != 0)
                {
                    tracker += Front.Value;
                }
                if (Front.LeftChild != null)
                {
                    queue.Enqueue(Front.LeftChild);
                }
                if (Front.RightChild != null)
                {
                    queue.Enqueue(Front.RightChild);
                }
            }
            return tracker;
        }


    }
}