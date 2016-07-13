using System;

namespace Ferrari
{
    public class Ferrari:ICar
    {
        public Ferrari(string driver, string model)
        {
            this.Driver = driver;
            this.Model = model;
        }

        public string Driver { get; }
        public string Model { get; }

        public void Brakes()
        {
            Console.Write("Brakes!");
        }

        public void Gas()
        {
            Console.Write("Zadu6avam sA!");
        }
    }
}
