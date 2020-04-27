using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
    {

        public LinkedList<Node>[] Bucket = new LinkedList<Node>[50];

        /// <summary>
        /// This allows us to add a key/value pair to the bucket. Deals with collision, if the 
        /// </summary>
        /// <param name="key">passes in the key</param>
        /// <param name="value">and passes the value</param>
        public void Add(string key, string value)
        {

            int num = Hash(key);
            Node node = new Node(key, value);

            if (Bucket[num] == null)
            {
                LinkedList<Node> list = new LinkedList<Node>();
                list.AddFirst(node);
                Bucket[num] = list;
            }
            else
            {
                Bucket[num].AddFirst(node);
            }


        }

        /// <summary>
        /// Hashes the key, it goes through each element in the key and returns the sum. If the sum is greater than the bucket length, it will extend the bucket
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int Hash(string key)
        {
            int sum = 0;
            for (int i = 0; i < key.Length; i++)
            {
                sum += key[i];
            }

            if (sum > Bucket.Length)
            {
                Array.Resize(ref Bucket, sum + Bucket.Length);
            }
            return sum;
        }

        /// <summary>
        /// this method gets the value from the given key.
        /// </summary>
        /// <param name="key">Takes in the key</param>
        /// <returns>Returns the value</returns>
        public string Get(string key)
        {
            int num = Hash(key);

            if (Bucket[num] == null)
            {
                return null;
            }
            Node head = Bucket[num].First();

            if (head.Next == null)
            {
                return head.Value;
            }

            while (head != null)
            {
                if (head.Key == key)
                {
                    return head.Value;
                }

                head = head.Next;
            }
            return null;
        }

        /// <summary>
        /// If the bucket has the key in it, it returns true, if empty, returns false
        /// </summary>
        /// <param name="key">the key</param>
        /// <returns>a boolean</returns>
        public bool Contains(string key)
        {
            int num = Hash(key);
            if (Bucket[num] != null)
            {
                return true;
            }
            return false;
        }

    }
}
