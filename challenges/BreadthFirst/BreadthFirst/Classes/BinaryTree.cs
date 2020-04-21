using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirst.Classes
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

        public static List<int> BreadthFirst(BinaryTree tree)
        {
            // instantiate a queue to use the queue methods
            Queue queue = new Queue();
            // create a list to add in the values to
            List<int> ListOfValues = new List<int>();

            queue.Enqueue(tree.Root);
            while (queue.Front != null)
            {
                Node front = queue.Dequeue();
                // adding the values into the list
                ListOfValues.Add(front.Value);

                // using the breadth first traversal
                if (front.LeftChild != null)
                {
                    queue.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    queue.Enqueue(front.RightChild);
                }
            }
            return ListOfValues;
        }
    }
}
