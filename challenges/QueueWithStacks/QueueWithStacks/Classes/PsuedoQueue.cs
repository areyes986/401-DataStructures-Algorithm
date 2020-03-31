using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PsuedoQueue
    {
        public Stack Stack1 { get; set; } = new Stack();
        public Stack Stack2 { get; set; } = new Stack();

        /// <summary>
        /// This method goes through the queue until its at the front, pop off all the values from stack 1 and pushes it to stack 2. Then push the inputted value into stack one and push everything from stack 2 back to stack 1
        /// </summary>
        /// <param name="num">the inputted value</param>
        public void Enqueue(int num)
        {
            while (Stack1.Top != null)
            {
                Stack2.Push(Stack1.Pop());
            }
            Stack1.Push(num);
            while (Stack2.Top != null)
            {
                Stack1.Push(Stack2.Pop());
            }
        }
        /// <summary>
        /// Pops off the value from the front of the queue
        /// </summary>
        /// <returns>The popped value</returns>
        public int Dequeue()
        {
            return Stack1.Pop();
        }
    }
}
