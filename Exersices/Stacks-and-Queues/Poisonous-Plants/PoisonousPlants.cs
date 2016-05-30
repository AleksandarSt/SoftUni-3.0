using System;
using System.Linq;

namespace Poisonous_Plants
{
    public class PoisonousPlants
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

        }
    }
}
