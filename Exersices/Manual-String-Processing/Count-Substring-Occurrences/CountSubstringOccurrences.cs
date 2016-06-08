using System;

namespace Count_Substring_Occurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
            string textToSearch = Console.ReadLine().ToLower();
            string givenSubstring = Console.ReadLine().ToLower();
            int appearanceCounter = 0;

            for (int i = 0; i <= textToSearch.Length - givenSubstring.Length; i++)
            {
                if (textToSearch.Substring(i, givenSubstring.Length) == givenSubstring)
                {
                    appearanceCounter++;
                }
            }

            Console.WriteLine(appearanceCounter);
        }
    }
}
