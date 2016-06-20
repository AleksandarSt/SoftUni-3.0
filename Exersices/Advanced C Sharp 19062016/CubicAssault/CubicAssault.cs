using System;
using System.Collections.Generic;
using System.Linq;

namespace CubicAssault
{
    class CubicAssault
    {
        const int ExchangeRate = 1000000;

        static void Main()
        {
            
            Dictionary<string, Dictionary<string, long>> statisticDict=new Dictionary<string, Dictionary<string, long>>();
            string line = Console.ReadLine();

            if (string.IsNullOrEmpty(line))
            {
                return;
            }
            string[] separators = {"->"};

            while (line!= "Count em all")
            {
                string[] currentLineElements = line.Split(separators,StringSplitOptions.None);
                string currentRegion = currentLineElements[0].Trim();
                string currentStoneType = currentLineElements[1].Trim();
                int currentQuantity = int.Parse(currentLineElements[2].Trim());

                if (!statisticDict.ContainsKey(currentRegion))
                {
                    statisticDict.Add(currentRegion, new Dictionary<string, long>() {{currentStoneType, currentQuantity}});

                    if (!statisticDict[currentRegion].ContainsKey("Green"))
                    {
                        statisticDict[currentRegion].Add("Green",0);
                    }

                    if (!statisticDict[currentRegion].ContainsKey("Red"))
                    {
                        statisticDict[currentRegion].Add("Red", 0);
                    }

                    if (!statisticDict[currentRegion].ContainsKey("Black"))
                    {
                        statisticDict[currentRegion].Add("Black", 0);
                    }
                }
                else
                {
                    Dictionary<string, long> currentStoneDict = statisticDict[currentRegion];

                    
                   

                    if (!currentStoneDict.ContainsKey(currentStoneType))
                    {
                        currentStoneDict.Add(currentStoneType,currentQuantity);
                    }
                    else
                    {
                        currentStoneDict[currentStoneType] += currentQuantity;
                    }

                }

                line = Console.ReadLine();
            }


            foreach (var region in statisticDict)
            {
                RecalculateStones(region.Value);
            }

            var orderedStructure = statisticDict
                .OrderByDescending(x => x.Value["Black"])
                .ThenBy(x=>x.Key.Length)
                .ThenBy(x => x.Key);

            foreach (var region in orderedStructure)
            {
                Console.WriteLine(region.Key);
                foreach (var stone in region.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"-> {stone.Key} : {stone.Value}");
                }
            }
        }

        private static void RecalculateStones(Dictionary<string, long> stoneDictionary)
        {
            if (stoneDictionary.ContainsKey("Green") &&
                Math.Abs(stoneDictionary["Green"] )>= ExchangeRate)
            {
                RecalculateStoneByType(stoneDictionary,"Green","Red");
            }

            if (stoneDictionary.ContainsKey("Red") &&
                Math.Abs(stoneDictionary["Red"]) >= ExchangeRate)
            {
                RecalculateStoneByType(stoneDictionary, "Red", "Black");
            }
        }

        private static void RecalculateStoneByType(Dictionary<string, long> stoneDictionary,string cheaperType, string expensiveType)
        {

            if (!stoneDictionary.ContainsKey(expensiveType))
            {
                stoneDictionary.Add(expensiveType, stoneDictionary[cheaperType] / ExchangeRate);
            }
            else
            {
                stoneDictionary[expensiveType] += stoneDictionary[cheaperType] / ExchangeRate;
            }
            stoneDictionary[cheaperType] = stoneDictionary[cheaperType]%ExchangeRate;
        }
    }
}
