using System;
using System.Collections.Generic;

namespace Periodic_table
{
    class PeriodicTable
    {
        static void Main()
        {
            int inputLines = int.Parse(Console.ReadLine());
            SortedSet<string> sortedSet=new SortedSet<string>();

            for (int i = 0; i < inputLines; i++)
            {
                string[] line = Console.ReadLine().Split();

                for (int j = 0; j < line.Length; j++)
                {
                    sortedSet.Add(line[j]);
                }
            }

            Console.WriteLine(string.Join(" ", sortedSet));
        }
    }
}
