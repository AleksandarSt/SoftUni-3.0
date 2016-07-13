using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Kermen.Factories;

namespace Kermen
{
    public class Startup
    {
        const string ProgramEnd = "Democracy";

        static void Main()
        {
            string input = Console.ReadLine();
            List<HouseHold> kermen=new List<HouseHold>();
            int counter = 0;

            while (input!= ProgramEnd)
            {
                counter++;
                try
                {
                   HouseHold entity= HouseHoldFactory.CreathHouseHold(input);
                    kermen.Add(entity);
                }
                catch (Exception)
                {
                    
                }

                if (counter%3==0)
                {
                    kermen.ForEach(x => x.GetIncome());
                }

                if (input=="EVN bill")
                {
                    kermen.RemoveAll(x => !x.CanPayBils());
                    kermen.ForEach(x=>x.PayBills());
                }

                if (input=="EVN")
                {
                    Console.WriteLine($"Total consumption: {kermen.Sum(x=>x.Consumption)}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total population: {kermen.Sum(x=>x.Population)}");
        }
    }
}
