using System;
using System.Collections.Generic;
using System.Linq;

namespace Raw_data
{
    class RawData
    {
        static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars=new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carParts = Console.ReadLine().Split();
                string model = carParts[0];
                int engineSpeed = int.Parse(carParts[1]);
                int enginePower = int.Parse(carParts[2]);
                Engine engine=new Engine(engineSpeed,enginePower);
                int cargoWeight = int.Parse(carParts[3]);
                string cargoType = carParts[4];
                Cargo cargo=new Cargo(cargoWeight,cargoType);
                double tyre1Pressure = double.Parse(carParts[5]);
                int tyre1Age = int.Parse(carParts[6]);
                Tyre tyre1 = new Tyre(tyre1Pressure, tyre1Age);
                double tyre2Pressure = double.Parse(carParts[7]);
                int tyre2Age = int.Parse(carParts[8]);
                Tyre tyre2 = new Tyre(tyre2Pressure, tyre2Age);
                double tyre3Pressure = double.Parse(carParts[9]);
                int tyre3Age = int.Parse(carParts[10]);
                Tyre tyre3 = new Tyre(tyre3Pressure, tyre3Age);
                double tyre4Pressure = double.Parse(carParts[11]);
                int tyre4Age = int.Parse(carParts[12]);
                Tyre tyre4 = new Tyre(tyre4Pressure, tyre4Age);
                Tyre[] tyres = {tyre1, tyre2, tyre3, tyre4};
                Car car=new Car(model,engine,cargo,tyres);

                cars.Add(car);
            }

            //if (Console.ReadLine()=="fragile")
            //{
            //    var result=cars.Where(car=>car.cargo.type=="fragile"&&car.tires.fi)
            //}
            //else
            //{
                
            //}
        }
    }
}
