using System;
using System.Collections.Generic;
using System.Numerics;

namespace Calculate_sequence_with_queue
{
    public class CalculateSequence
    {
        public static void Main()
        {
            const int lastMemberOfSequence = 50;

            BigInteger currentSum = BigInteger.Parse(Console.ReadLine());
            int elementNumber = 0;
            Queue<BigInteger> queue = new Queue<BigInteger>();

            queue.Enqueue(currentSum);

            do
            {
                currentSum = queue.Dequeue();
                Console.Write("{0} ", currentSum);
                queue.Enqueue(currentSum + 1);
                queue.Enqueue(2*currentSum + 1);
                queue.Enqueue(currentSum + 2);
                elementNumber++;

            } while (elementNumber < lastMemberOfSequence);
        }
    }
}
