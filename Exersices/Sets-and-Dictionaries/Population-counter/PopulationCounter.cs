using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_counter
{
    class PopulationCounter
    {
        static void Main()
        {
            string[] command = Console.ReadLine().Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Dictionary<string, long>> populationByCountry =
                new Dictionary<string, Dictionary<string, long>>();

            while (command[0] != "report")
            {
                string country = command[1];
                string city = command[0];
                int cityPopulation = int.Parse(command[2]);

                if (!populationByCountry.ContainsKey(country))
                {
                    populationByCountry.Add(country, new Dictionary<string, long>());
                    populationByCountry[country].Add("totalPopulation", 0);
                }

                if (!populationByCountry[country].ContainsKey(city))
                {

                    populationByCountry[country].Add(city, cityPopulation);
                    populationByCountry[country]["totalPopulation"] += cityPopulation;
                }

                command = Console.ReadLine().Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
            }

            var ordered = populationByCountry.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var item in ordered)
            {
                Console.WriteLine("{0} (total population: {1})", item.Key, item.Value.Values.Sum()/2);

                foreach (var inner in item.Value.OrderByDescending(x => x.Value))
                {
                    if (inner.Key != "totalPopulation")
                    {
                        Console.WriteLine("=>{0}: {1}", inner.Key, inner.Value);
                    }
                }
            }
        }
    }
}
