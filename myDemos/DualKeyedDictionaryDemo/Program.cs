using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualKeyedDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DualKeyedDictionary<string, string, string> info = new DualKeyedDictionary<string, string, string>();
            info.Add("A", "B", "C");
            info.Add("1", "2", "3");


            string temp = GetValue(info, "A");

            //foreach (var outerEntry in info)
            //{
            //    foreach (var innerEntry in outerEntry.Value)
            //    {
            //        Console.WriteLine("Key:{0} Value:{1}", innerEntry.Key, innerEntry.Value);
            //    }
            //}
        }
        public static string GetValue(DualKeyedDictionary<string, string, string> info,
                               string search)
        {

            string retval = "";

            var x = info["A"];

            Dictionary<string, string> mydict;

            mydict = x;

            // string myval = x.Value;

            foreach (var outerEntry in info)
            {
                if (outerEntry.Key == search)
                {
                    foreach (var innerEntry in outerEntry.Value)
                    {
                        Console.WriteLine("Key:{0} Value:{1}", innerEntry.Key, innerEntry.Value);
                        retval = innerEntry.Value;
                    }
                }
            }
            return retval;
        }

        public class DualKeyedDictionary<TKey1, Tkey2, TValue> : Dictionary<TKey1, Dictionary<Tkey2, TValue>>
        {

            public void Add(TKey1 myKey1, Tkey2 myKey2, TValue myValue)
            {
                if (!this.ContainsKey(myKey1))
                {
                    Dictionary<Tkey2, TValue> myDictionary = new Dictionary<Tkey2, TValue>();
                    myDictionary.Add(myKey2, myValue);
                    this.Add(myKey1, myDictionary);
                }
                else
                {
                    this[myKey1].Add(myKey2, myValue);
                }

            }

            public bool ContainsKey(TKey1 myKey1, Tkey2 myKey2)
            {
                return this.ContainsKey(myKey1) && this[myKey1].ContainsKey(myKey2);

            }


        }


    }

}