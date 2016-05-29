using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Parentheses
{
    class BalancedParentheses
    {
        static void Main()
        {
           char[] Opening = { '{', '[', '(' };

            string input = Console.ReadLine();

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Opening.Contains(input[i]))
                {
                    stack.Push(input[i].ToString());
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    if (!IsBalanced(stack.Peek(), input[i].ToString()))
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    stack.Pop();
                }
            }

            Console.WriteLine("YES");
        }

        private static bool IsBalanced(string openingParenthesis, string closingParanthesis)
        {
            bool isBalanced;

            if (openingParenthesis=="(")
            {
                isBalanced = closingParanthesis == ")";
            }
            else if (openingParenthesis=="[")
            {
                isBalanced = closingParanthesis == "]";
            }
            else
            {
                isBalanced = closingParanthesis == "}";
            }

            return isBalanced;
        }
    }
}
