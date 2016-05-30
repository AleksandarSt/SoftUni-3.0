using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    public class CountSymbols
    {
        static void Main()
        {
            char[] text = Console.ReadLine().ToCharArray();

            Dictionary<char, int> dictionary=new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!dictionary.ContainsKey(text[i]))
                {
                    dictionary.Add(text[i],1);
                }
                else
                {
                    dictionary[text[i]] += 1;
                }
            }

            foreach (var item in dictionary.OrderBy(x=>x.Key))
            {
                Console.WriteLine("{0}: {1} time/s",item.Key,item.Value);
            }

            
        }
    }
}
