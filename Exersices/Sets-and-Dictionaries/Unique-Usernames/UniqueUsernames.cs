using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    class UniqueUsernames
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            HashSet<string> hashSet=new HashSet<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string line = Console.ReadLine();
                hashSet.Add(line);
            }

            foreach (var name in hashSet)
            {
                Console.WriteLine(name);
            }
        }
    }
}
