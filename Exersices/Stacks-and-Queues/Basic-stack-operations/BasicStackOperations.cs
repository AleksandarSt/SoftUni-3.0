using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Basic_stack_operations
{
    public class BasicStackOperations
    {
        public static void Main()
        {
            int[] parameters = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack=new Stack<int>();

            foreach (var number in numbers)
            {
                stack.Push(number);
            }

            for (int i = 0; i < parameters[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Count==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                string result = stack.Contains(parameters[2])
                    ? "true"
                    : stack.ToArray().Min().ToString();

                Console.WriteLine(result);
            }
        }
    }
}
