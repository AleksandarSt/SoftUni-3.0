using System;

namespace Ferrari
{
    public class Startup
    {
        static void Main()
        {
            string driver = Console.ReadLine();

            ICar ferrari=new Ferrari(driver, "488-Spider");

            Console.Write($"{ferrari.Model}/");
            ferrari.Brakes();
            Console.Write("/");
            ferrari.Gas();
            Console.Write("/");
            Console.WriteLine($"{ferrari.Driver}");

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }

        }
    }
}
