using Hashtables.Classes;
using System;
using System.Collections.Generic;

namespace LeftJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Hashtable synonyms = new Hashtable();
            synonyms.Add("happy", "joyful");
            synonyms.Add("beautiful", "pretty");
            synonyms.Add("tall", "giant");

            Hashtable antonyms = new Hashtable();
            antonyms.Add("happy", "sad");
            antonyms.Add("beautiful", "ugly");
            antonyms.Add("tall", "short");

            LeftJoin(synonyms, antonyms);
        }


        public static void LeftJoin(Hashtable table1, Hashtable table2)
        {
            //string key = "";
            //int hashedKey1 = table1.Hash(key.ToString());
            //string value1 = table1.Get(hashedKey1.ToString());

            //string key2 = "";
            //table2.Hash(key2);
            //int hashedKey2 = table1.Hash(key.ToString());
            //string value2 = table1.Get(hashedKey2.ToString());

            //Node node1 = new Node(hashedKey1.ToString(), value1);
            //Node node2 = new Node(hashedKey2.ToString(), value2);

            //LinkedList<Node> list = new LinkedList<Node>();
            //if (hashedKey1 == hashedKey2)
            //{
            //    list.AddFirst(node1);
            //    list.AddFirst(node2);
            //}

            for (int i = 0; i < table1.Bucket.Length; i++)
            {
                if(table1.Bucket[i] != null)
                {
                    if(table2.Bucket[i] == null)
                    {
                        Node node = new Node("null", "null");
                        table1.Bucket[i].AddFirst(node);
                    }
                    else
                    {
                        var tb2Val = table2.Bucket[i].First.Value;
                        table1.Bucket[i].AddFirst(tb2Val);
                    }
                }
            }



        }
    }
}
