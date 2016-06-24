using System;

namespace Speed_racing
{
    public class Car
    {
        public string model;
        public decimal fuelAmount;
        public decimal fuelCostPerKm;
        public decimal distanceTraveled;

        public Car(string model, decimal fuelAmount, decimal fuelCostPerKm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelCostPerKm = fuelCostPerKm;
        }

        public void Drive(string carModel, decimal amountOfKm)
        {
            if (this.model==carModel&&amountOfKm*fuelCostPerKm<=fuelAmount)
            {
                this.fuelAmount = fuelAmount - amountOfKm*fuelCostPerKm;
                this.distanceTraveled += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
