using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Recursive_Fibonachi
{
    class RecursiveFibonachi
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Queue<long> queue=new Queue<long>();

            for (int i = 0; i < number; i++)
            {
                if (i==0||i==1)
                {
                    queue.Enqueue(1);
                }
                else
                {
                    queue.Enqueue(queue.Dequeue()+queue.Peek());
                }
            }

            queue.Dequeue();
            Console.WriteLine(queue.Dequeue());
        }
    }
}
