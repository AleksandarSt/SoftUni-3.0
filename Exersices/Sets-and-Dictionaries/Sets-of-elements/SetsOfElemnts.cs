using System;
using System.Collections.Generic;

namespace Sets_of_elements
{
    class SetsOfElemnts
    {
        static void Main()
        {
            string[] setSizes = Console.ReadLine().Split();

            HashSet<int> firstHashSet=new HashSet<int>();
            HashSet<int> secondHashSet=new HashSet<int>();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < int.Parse(setSizes[i]); j++)
                {
                    string line = Console.ReadLine();
                    if (i==0)
                    {
                        firstHashSet.Add(int.Parse(line));
                    }
                    else
                    {
                        secondHashSet.Add(int.Parse(line));
                    }
                } 
            }

            firstHashSet.IntersectWith(secondHashSet);
            Console.WriteLine(string.Join(" ",firstHashSet));
        }
    }
}
