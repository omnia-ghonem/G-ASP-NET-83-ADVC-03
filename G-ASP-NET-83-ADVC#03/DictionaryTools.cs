using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_ADVC_03
{
    public class DictionaryTools
    {
        public static void CheckIfFound<T1, T2>(Dictionary<T1, T2> dic , T1 key) {
            T2 value;
         if(!dic.TryGetValue(key, out value))
                Console.WriteLine($"{key} does not exist in the phone book.");

            Console.WriteLine($"Key: {key} Value: {value}");

        }

        public static void CheckIfFound<T1, T2>(Dictionary<T1, T2> dic, List<T1> list)
        {
            T2 value;
            foreach (T1 key in list)
            {
                if (!dic.TryGetValue(key, out value)) { 
                Console.WriteLine($"{key} does not exist in the phone book.");
                } else {
                    Console.WriteLine($"Key: {key} Value: {value}");

                }
                
            }
        }
        public static void PrintKVDifferLine<T1, T2>(Dictionary<T1, T2> dic)
        {
            Console.WriteLine($"Keys: {string.Join(", ",dic.Keys)}");
            Console.WriteLine($"Values: {string.Join(", ",dic.Values)}");
        }
    }
}
