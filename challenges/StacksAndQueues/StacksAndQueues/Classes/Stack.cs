using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; } = null;

        /// <summary>
        /// Push method creates a new node, sets the value to the arg
        /// The new nodes next is going to = top then top with then = node
        /// </summary>
        /// <param name="number"> input number</param>
        public void Push(int number)
        {
            Node node = new Node();
            node.Value = number;
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Takes off the top off of the stack
        /// </summary>
        /// <returns>New Tops value</returns>
        public int Pop()
        {
            if (Top == null)
            {
                throw new Exception("Stack is empty, nothing to pop off!");
            }
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp.Value;
        }


        /// <summary>
        /// Checks if the stack is empty or not
        /// </summary>
        /// <returns> 
        /// A bool, if the stack is empty, return true. 
        /// if the stack there is something, retur false.
        /// </returns>
        public bool IsEmpty()
        {
            if (Top != null)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// This methods is supposed to tell us what the top's value is.
        /// </summary>
        /// <returns> Returns the tops value if there is a top, throws exception if empty</returns>
        public int Peek()
        {
            if (Top == null)
            {
                throw new Exception("The stack is empty!");
            }
            return Top.Value;
        }
    }
}
