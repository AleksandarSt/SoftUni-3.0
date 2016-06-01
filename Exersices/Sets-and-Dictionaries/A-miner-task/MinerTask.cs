using System;
using System.Collections.Generic;
using System.Numerics;

namespace A_miner_task
{
    class MinerTask
    {
        static void Main()
        {
            Dictionary<string, BigInteger> miner = new Dictionary<string, BigInteger>();
            string line = Console.ReadLine();
            int counter = 1;
            string currentKey="";

            do
            {
                if (line=="stop")
                {
                    return;
                }

                if (counter%2 != 0)
                {
                    currentKey = line;
                    if (!miner.ContainsKey(line))
                    {
                        miner.Add(line, 0);
                    }
                }
                else
                {
                    miner[currentKey] += BigInteger.Parse(line);
                }

                line = Console.ReadLine();
                counter++;
            } while (line != "stop");

            foreach (var resource in miner)
            {
                Console.WriteLine("{0} -> {1}", resource.Key, resource.Value);
            }
                

        }
    }
}
