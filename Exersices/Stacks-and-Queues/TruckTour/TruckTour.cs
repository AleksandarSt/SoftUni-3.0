using System;
using System.Collections.Generic;

namespace TruckTour
{
    public class TruckTour
    {
        static void Main()
        {
            int numberOfPumps = int.Parse(Console.ReadLine());

            Queue<GasPump> pumps=new Queue<GasPump>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                string[] pumpInfo = Console.ReadLine().Split();
                int distanceToNext = int.Parse(pumpInfo[1]);
                int amountOfGas = int.Parse(pumpInfo[0]);
                GasPump pump=new GasPump(amountOfGas,distanceToNext,i);

                pumps.Enqueue(pump);
            }

            GasPump startingPump = null;

            while (true)
            {
                GasPump currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);
                startingPump = currentPump;
                int gasInTank = currentPump.AmountOfGas;
                bool isCircleCompleted = false;

                while (gasInTank>=currentPump.DistanceToNext)
                {

                    gasInTank -= currentPump.DistanceToNext;
                    currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);

                    if (currentPump==startingPump)
                    {
                        isCircleCompleted = true;
                        break;
                    }
                    gasInTank += currentPump.AmountOfGas;
                }

                if (isCircleCompleted)
                {
                    Console.WriteLine(startingPump.IndexOfPump);
                    break;
                }
            }
        }
    }

    public class GasPump
    {
        public int AmountOfGas { get; set; }
        public int DistanceToNext { get; set; }
        public int IndexOfPump { get; set; }

        public GasPump(int amountOfGas, int distanceToNext, int indexOfPump)
        {
            this.AmountOfGas = amountOfGas;
            this.DistanceToNext = distanceToNext;
            this.IndexOfPump = indexOfPump;
        }
    }
}
