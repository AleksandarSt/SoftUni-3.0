using System;
using System.Collections.Generic;

namespace Stack_Fibonacci
{
    class StackFibonacci
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Stack<long> stack=new Stack<long>();

            for (int i = 0; i < number; i++)
            {
                if (i==0||i==1)
                {
                    stack.Push(1);
                }
                else
                {
                    long lastElement = stack.Pop();
                    long newElement = lastElement + stack.Peek();
                    stack.Push(lastElement);
                    stack.Push(newElement);
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
