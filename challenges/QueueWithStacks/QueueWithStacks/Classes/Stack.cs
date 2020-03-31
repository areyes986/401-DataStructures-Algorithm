using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public void Push(int number)
        {
            Node node = new Node();
            node.Value = number;
            node.Next = Top;
            Top = node;
        }

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
