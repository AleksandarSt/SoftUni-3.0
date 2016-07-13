using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOP_Basics_Exam.Factories;

namespace OOP_Basics_Exam
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, HardwareComponent> system = new Dictionary<string, HardwareComponent>();
            Dictionary<string, HardwareComponent> dump = new Dictionary<string, HardwareComponent>();

            while (input != "System Split")
            {

                try
                {
                    HardwareComponent component = HardwareComponentFactory.CreateComponent(input);
                    system.Add(component.Name, component);
                }
                catch (Exception)
                {

                }

                string[] inputArgs = input.Split(new char[] {',', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);
                string command = inputArgs[0];

                if (command == "RegisterExpressSoftware" || command == "RegisterLightSoftware")
                {
                    string hardwareComponentName = inputArgs[1];

                    if (system.ContainsKey(hardwareComponentName))
                    {
                        SoftwareComponent softwareComponent = SoftwareComponentFactory.CreateComponent(input);
                        system[hardwareComponentName].RegisterSoftwareComponent(softwareComponent);
                    }
                }

                if (command == "ReleaseSoftwareComponent")
                {
                    string hardwareComponentName = inputArgs[1];
                    string softwareComponentName = inputArgs[2];

                    if (system.ContainsKey(hardwareComponentName) &&
                        system[hardwareComponentName].SoftwareComponents.ContainsKey(softwareComponentName))
                    {
                        var softwareComponentForRelease =
                            system[hardwareComponentName].SoftwareComponents[softwareComponentName];

                        system[hardwareComponentName].DestroySoftwareComponent(softwareComponentForRelease);
                    }
                }

                if (command == "Analyze")
                {
                    Console.WriteLine(GetSystemStatus(system));
                }

                
                if (command == "Dump")
                {
                    string hardwareComponentName = inputArgs[1];

                    if (system.ContainsKey(hardwareComponentName))
                    {
                        dump.Add(hardwareComponentName, system[hardwareComponentName]);
                        system.Remove(hardwareComponentName);
                    }
                }

                if (command== "DumpAnalyze")
                {
                    Console.WriteLine(GetDumpStatus(dump));
                }

                if (command== "Restore")
                {
                    string hardwareComponentName = inputArgs[1];

                    if (dump.ContainsKey(hardwareComponentName))
                    {
                        system.Add(hardwareComponentName, dump[hardwareComponentName]);
                        dump.Remove(hardwareComponentName);
                    }
                }

                if (command== "Destroy")
                {
                    string hardwareComponentName = inputArgs[1];

                    if (dump.ContainsKey(hardwareComponentName))
                    {
                        dump.Remove(hardwareComponentName);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var hardware in system.OrderByDescending(x=>x.Value.Type))
            {
                Console.WriteLine(hardware.Value);
            }
        }

        private static string GetDumpStatus(Dictionary<string, HardwareComponent> dump)
        {
            StringBuilder dumpAnalys = new StringBuilder();
            dumpAnalys.Append($"Dump Analysis");
            dumpAnalys.Append(Environment.NewLine);
            dumpAnalys.Append($"Power Hardware Components: {dump.Count(x => x.Value.Type == "Power")}");
            dumpAnalys.Append(Environment.NewLine);
            dumpAnalys.Append($"Heavy Hardware Components: {dump.Count(x => x.Value.Type == "Heavy")}");
            dumpAnalys.Append(Environment.NewLine);
            dumpAnalys.Append($"Express Software Components: {dump.Values.Sum(x=>x.SoftwareComponents.Count(s=>s.Value.Type=="Express"))}");
            dumpAnalys.Append(Environment.NewLine);
            dumpAnalys.Append($"Light Software Components: {dump.Values.Sum(x => x.SoftwareComponents.Count(s => s.Value.Type == "Light"))}");
            dumpAnalys.Append(Environment.NewLine);
            dumpAnalys.Append($"Total Dumped Memory: {dump.Sum(x => x.Value.CurrentMemory)}");
            dumpAnalys.Append(Environment.NewLine);
            dumpAnalys.Append($"Total Dumped Capacity: {dump.Sum(x => x.Value.CurrentCapacity)}");

            return dumpAnalys.ToString();
        }

        private static string GetSystemStatus(Dictionary<string, HardwareComponent> system)
        {
            StringBuilder systemAnalysis = new StringBuilder();
            systemAnalysis.Append("System Analysis");
            systemAnalysis.Append(Environment.NewLine);
            systemAnalysis.Append($"Hardware Components: {system.Count}");
            systemAnalysis.Append(Environment.NewLine);
            systemAnalysis.Append(
                $"Software Components: {system.Sum(x => x.Value.SoftwareComponents.Count)}");
            systemAnalysis.Append(Environment.NewLine);
            systemAnalysis.Append(
                $"Total Operational Memory: {system.Sum(x => x.Value.CurrentMemory)} / {system.Sum(x => x.Value.MaximumMemory)}");
            systemAnalysis.Append(Environment.NewLine);
            systemAnalysis.Append(
                $"Total Capacity Taken: {system.Sum(x => x.Value.CurrentCapacity)} / {system.Sum(x => x.Value.MaximumCapacity)}");

            return systemAnalysis.ToString();
        }
    }
}
