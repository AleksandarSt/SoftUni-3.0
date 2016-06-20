using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace CubicsRube
{
    class CubicsRube
    {
        static void Main()
        {
            int dimension= int.Parse(Console.ReadLine());
            int numberOfEmptyCells = dimension*dimension*dimension;

            Dictionary<string,long> cube=new Dictionary<string, long>();

            string line = Console.ReadLine();

            while (line != "Analyze")
            {
                long[] currentParams = line.Split().Select(long.Parse).ToArray();
                long xCord = currentParams[0];
                long yCord = currentParams[1];
                long zCord = currentParams[2];
                long particle = currentParams[3];

                if (IsPointInsideCube(xCord,yCord,zCord,dimension))
                {
                    if (!cube.ContainsKey($"{xCord},{yCord},{zCord}"))
                    {
                        cube.Add($"{xCord},{yCord},{zCord}",particle);
                        if (particle!=0)
                        {
                            numberOfEmptyCells--;
                        }
                        
                    }
                    else
                    {
                        cube[$"{xCord},{yCord},{zCord}"] += particle;
                    }

                }
                line = Console.ReadLine();
            }

            BigInteger Sum = 0;
            foreach (var cell in cube)
            {
                Sum += cell.Value;
            }
            //Console.WriteLine(cube.Sum(x=>x.Value));
            Console.WriteLine(Sum);
            //Console.WriteLine(numberOfEmptyCells-cube.Count);
            Console.WriteLine(numberOfEmptyCells);
        }

        static bool IsPointInsideCube(long dimensionX, long dimensionY, long dimensionZ, long cubeDimension)
        {
            bool isXInside = dimensionX >= 0 && dimensionX < cubeDimension;
            bool isYInside = dimensionY >= 0 && dimensionY < cubeDimension;
            bool isZInside = dimensionZ >= 0 && dimensionZ < cubeDimension;
            return isXInside && isYInside && isZInside;
        }
    }
}
