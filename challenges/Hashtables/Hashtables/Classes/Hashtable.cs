using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
    {

        public string[] Bucket = new string[50];

        public void Add(string key, string value)
        {
            int num = Hash(key);
            Bucket[num] = value;
        }


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

        //get: takes in the key and returns the value from the table.
        //contains: takes in the key and returns a boolean, indicating if the key exists in the table already.

        public string Get(string key)
        {
            int num = Hash(key);
            return Bucket[num];
        }

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
