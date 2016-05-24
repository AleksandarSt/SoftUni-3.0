using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_element
{
    public class MaximumElement
    {
        public static void Main()
        {
            int numberOfQueries = int.Parse(Console.ReadLine());

            Stack<int> stack=new Stack<int>();

            for (int i = 0; i < numberOfQueries; i++)
            {
                //var numbers = Console.ReadLine()
                //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                //    .Select(int.Parse)
                //    .ToArray();

                var numbers = Console.ReadLine();
                

                switch (int.Parse(numbers[0].ToString()))
                {
                    case 1:
                       var numberToPush = int.Parse(numbers.Substring(1));
                        stack.Push(numberToPush);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        Console.WriteLine(stack.ToArray().Max());
                        break;
                }
            }
        }
    }
}
