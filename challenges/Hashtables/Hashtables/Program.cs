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
            int mochiNum = ht.Hash("mochi is a");
            ht.Add("mochi is a", "fool");
            //Console.WriteLine(ht.Bucket[mochiNum]);
            
            Console.WriteLine(ht.Get("mochi is a"));
        }


    }
}
