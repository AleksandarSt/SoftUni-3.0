using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues
{
    public class ReverseNumbers
    {
        public static void Main()
        {
            /*
             * Problem 1.	Reverse Numbers with a Stack
             * Write a program that reads N integers from the console and reverses them using a stack. 
             * Use the Stack<int> class from .NET Framework. Just put the input numbers in the stack and pop them. 
             */


            int[] numbers = Console.ReadLine()
                .Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbersStack=new Stack<int>();

            foreach (var number in numbers)
            {
                numbersStack.Push(number);
            }

            Console.WriteLine(string.Join(" ",numbersStack));
        }
    }
}
