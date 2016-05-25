using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_queue_operations
{
    public class BasicQueueOperations
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

            Queue<int> queue=new Queue<int>();

            foreach (var number in numbers)
            {
                queue.Enqueue(number);
            }

            for (int i = 0; i < parameters[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                string result = queue.Contains(parameters[2])
                    ? "true"
                    : queue.ToArray().Min().ToString();

                Console.WriteLine(result);
            }
        }
    }
}
