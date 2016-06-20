using System;
using System.Text;

namespace CubicArtillery
{
    class CubicArtillery
    {
        static void Main()
        {
            int macCapacity = int.Parse(Console.ReadLine());

            string[] line = Console.ReadLine().Split();

            StringBuilder weapons=new StringBuilder();

            for (int i = 1; i < line.Length-2; i++)
            {
                weapons.Append(line[i] + ", ");
            }

            weapons.Remove(weapons.Length - 2, 2);

            Console.WriteLine($"{line[0]} -> {weapons}");
        }
    }
}
