using System;
using System.Text.RegularExpressions;

namespace Regular_expressions
{
    public class MatchFullName
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"\b(?<firstname>[A-Z]{1}[a-z]+) (?<lastname>[A-Z]{1}[a-z]+)\b";

            Regex regex=new Regex(pattern);
            while (true)
            {
                if (regex.IsMatch(text))
                {
                    Console.WriteLine(regex.Match(text));
                }
                
                text = Console.ReadLine();
            }
            
        }
    }
}
