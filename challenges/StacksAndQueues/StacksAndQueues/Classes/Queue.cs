using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; } = null;

        private Node Rear { get; set; }


        /// <summary>
        /// To add a node to the queue, it adds from the rear. If empty, the new node will enter the queue
        /// </summary>
        /// <param name="number"> input number</param>
        public void Enqueue(int number)
        {
            if (Front == null)
            {
                Node node = new Node();
                node.Value = number;
                Front = node;
                Rear = node;
            }
            else
            {
            Node node = new Node();
            node.Value = number;

            Rear.Next = node;
            Rear = node;
            }
        }

        /// <summary>
        /// You take off the node from the front,
        /// Then the Front will = the front's next
        /// Then have the temps next = null to pop it off then just return the value
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            if (Front == null)
            {
                throw new Exception("Queue empty! Cannot dequeue!");
            }
            else
            {
                Node temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp.Value;
            }

        }

        /// <summary>
        /// Method is returns the Fronts value, if its empty, throws and exceptions
        /// </summary>
        /// <returns> Front's value </returns>

        public int Peek()
        {
            if (Front == null)
            {
                throw new Exception("The Queue is empty!");
            }
            return Front.Value;
        }

        /// <summary>
        /// Checks if the queue is empty or not
        /// </summary>
        /// <returns>true is queue is empty, false if not empty</returns>
        public bool IsEmpty()
        {
            if (Front != null)
            {
                return false;
            }
            return true;
        }
    }
}
