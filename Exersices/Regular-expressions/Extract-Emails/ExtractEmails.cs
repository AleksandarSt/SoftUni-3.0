using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?:^|\s)((?:[a-zA-Z0-9]+[.\-_])*[a-zA-Z0-9]+@(?:[a-zA-Z]+-?)+(?:\.[a-zA-Z]+)+)(?:\.\s)?";
            Regex matcher=new Regex(pattern);
            MatchCollection collection = matcher.Matches(input);

            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i].Groups[1].Value);
            }
        }
    }
}
