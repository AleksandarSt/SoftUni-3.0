using System;
using System.Collections.Generic;

namespace OOP_Basics_Exam.Factories
{
    class HardwareComponentFactory
    {
        public static HardwareComponent CreateComponent(string input)
        {
            string[] inputArgs = input.Split(new char[] {',', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);
            string command = inputArgs[0];

            if (command== "RegisterPowerHardware")
            {
                return CretePowerHardware(inputArgs);
            }
            else if(command== "RegisterHeavyHardware")
            {
                return CreateHeavyHardware(inputArgs);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private static HardwareComponent CreateHeavyHardware(string[] inputArgs)
        {
            string hardwareType = "Heavy";
            string hardwareName = inputArgs[1];
            int hardwareCapacity = int.Parse(inputArgs[2]);
            int hardwareMemory = int.Parse(inputArgs[3]);

            return new HeavyHardware(hardwareName, hardwareType, hardwareCapacity, hardwareMemory);
        }

        private static HardwareComponent CretePowerHardware(string[] inputArgs)
        {
            string hardwareType = "Power";
            string hardwareName = inputArgs[1];
            int hardwareCapacity = int.Parse(inputArgs[2]);
            int hardwareMemory = int.Parse(inputArgs[3]);

            return new PowerHardware(hardwareName, hardwareType, hardwareCapacity, hardwareMemory);
        }
    }
}
