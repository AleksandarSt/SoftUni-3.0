using System;
using System.Linq;
using System.Reflection;

namespace Class_Box
{
    class Startup
    {
        static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            try
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                var box = new Box(length, width, height);

                box.CalculateSurfaceArea();
                box.CalculateLateralSurfaceArea();
                box.CalculateVolume();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
