using System;
using System.Collections.Generic;

namespace Speed_racing
{
    class SpeedRacing
    {
        static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            var cars=new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var currentCar = new Car(carInfo[0], decimal.Parse(carInfo[1]), decimal.Parse(carInfo[2]));
                
                cars.Add(currentCar);
            }

            string line = Console.ReadLine();

            while (line!="End")
            {
                string[] currentCommand = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                foreach (var car in cars)
                {
                    if (car.model==currentCommand[1])
                    {
                        car.Drive(currentCommand[1],decimal.Parse(currentCommand[2]));
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.model} {car.fuelAmount:F2} {car.distanceTraveled}");
            }
        }
    }
}
