using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        public Animals Front { get; set; } = null;
        public Animals Rear { get; set; }

        /// <summary>
        /// adding an animal to the shelter, can be either a cat or dog
        /// </summary>
        public void Enqueue(Animals animal)
        {
            if (Front == null)
            {
                Front = animal;
                Rear = animal;
            }
            else
            {
                Rear.Next = animal;
                Rear = animal;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pref">the preference of either cat or dog</param>
        /// <returns></returns>
        public Animals Dequeue(Animals pref)
        {
            if (Front == pref)
            {
                return Front;
            }
            else if (Front == null)
            {
                throw new Exception("There are no animals in the shelter!");
            }
            else
            {
                return null;
            }
        }
    }
}



