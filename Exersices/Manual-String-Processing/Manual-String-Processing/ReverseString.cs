using System;
using System.Text;

namespace Reverse_String
{
    class ReverseString
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            StringBuilder reversed=new StringBuilder();

            for (int i = input.Length-1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            Console.WriteLine(reversed);
        }
    }
}
