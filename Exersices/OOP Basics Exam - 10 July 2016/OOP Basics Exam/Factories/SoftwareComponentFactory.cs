using System;

namespace OOP_Basics_Exam.Factories
{
    class SoftwareComponentFactory
    {
        public static SoftwareComponent CreateComponent(string input)
        {
            string[] inputArgs = input.Split(new char[] {',', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);
            string command = inputArgs[0];

            if (command == "RegisterExpressSoftware")
            {
                return CreateExpressSoftware(inputArgs);
            }
            else if(command == "RegisterLightSoftware")
            {
                return CreateLightSoftware(inputArgs);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private static SoftwareComponent CreateLightSoftware(string[] inputArgs)
        {
            string softwareType = "Light";
            string softwareName = inputArgs[2];
            int softwareCapacity = int.Parse(inputArgs[3]);
            int softwareMemory = int.Parse(inputArgs[4]);

            return new LightSoftware(softwareName, softwareType, softwareCapacity, softwareMemory);
        }

        private static SoftwareComponent CreateExpressSoftware(string[] inputArgs)
        {
            string softwareType = "Express";
            string softwareName = inputArgs[2];
            int softwareCapacity = int.Parse(inputArgs[3]);
            int softwareMemory = int.Parse(inputArgs[4]);

            return new ExpressSoftware(softwareName, softwareType, softwareCapacity, softwareMemory);
        }
    }
}
