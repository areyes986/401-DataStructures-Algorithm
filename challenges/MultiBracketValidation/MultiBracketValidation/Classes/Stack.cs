using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
{
    class Stack
    {
        public Node Top { get; set; }

        public void Push(string input)
        {
            Node node = new Node();
            node.Value = input;
            node.Next = Top;
            Top = node;
        }

        public string Pop()
        {
            if (Top == null)
            {
                throw new Exception("There is nothing in the stack!");
            }

            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp.Value;
        }

        public string Peek()
        {
            if (Top == null)
            {
                throw new Exception("There is nothing in the stack!");
            }
            return Top.Value;
        }

        public bool IsEmpty()
        {
            if (Top != null)
            {
                return false;
            }
            return true;
        }


    }
}
