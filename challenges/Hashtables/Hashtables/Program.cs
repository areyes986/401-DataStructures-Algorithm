using Hashtables.Classes;
using System;

namespace Hashtables
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddToBucket();
        }

        public static void AddToBucket()
        {
            Hashtable ht = new Hashtable();
            int num = ht.Hash("jin");
            ht.Add("jin", "fool");
            //Console.WriteLine(ht.Bucket[num]);
            
            Console.WriteLine(ht.Get("jin"));
        }


    }
}
