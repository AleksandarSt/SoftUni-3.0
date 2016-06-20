using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CubicsMessage
{
    class CubicsMessage
    {
        static void Main()
        {

            string line = Console.ReadLine();
            List<string>messages=new List<string>();

            while (line!="Over!")
            {
                int currentNumber = int.Parse(Console.ReadLine());

                string pattern = $@"(^[0-9]+)([a-zA-Z]{{currentNumber}})([^a-zA-Z]*)?$";
                Regex regex=new Regex(pattern);
                Match match = regex.Match(line);

                line = Console.ReadLine();
            }

            var test = 0;
        }
    }
}
