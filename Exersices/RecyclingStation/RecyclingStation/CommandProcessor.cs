using System;
using System.Xml;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation
{
    class CommandProcessor
    {
        private readonly IGarbageProcessor garbageProcessor;
        private readonly RecyclingStation recyclingStation;

        public CommandProcessor(RecyclingStation recyclingStation,IGarbageProcessor garbageProcessor)
        {
            this.garbageProcessor = garbageProcessor;
            this.recyclingStation = recyclingStation;
        }

        public void ProccesCommand(string command)
        {
            string[] commandArgs = command.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

            string commandName = commandArgs[0];

            if (commandName == "ProcessGarbage")
            {
                ProcessGarbage(commandArgs);
            }
            else if (commandName == "Status")
            {
                GetStatus();
            }
            else if (commandName == "ChangeManagementRequirement")
            {
                ChangeManagementRequirements(commandArgs);
            }
            else
            {
                throw new InvalidOperationException("Invalid command!");
            }
        }

        private void GetStatus()
        {
            var status = $"Energy: {recyclingStation.Energy:F2} Capital: {recyclingStation.Capital:F2}";

            Console.WriteLine(status);
        }

        private void ChangeManagementRequirements(string[] commandArgs)
        {
            double energyBalance = double.Parse(commandArgs[1]);
            double capitalBalance = double.Parse(commandArgs[2]);
            string type = commandArgs[3];

            recyclingStation.RequiredCapital = capitalBalance;
            recyclingStation.RequiredEnergy = energyBalance;

            Console.WriteLine("Management requirement changed!");
        }

        private void ProcessGarbage(string[] commandArgs)
        {
            string garbageName = commandArgs[1];
            double garbageWeight = double.Parse(commandArgs[2]);
            double garbageVolumePerKg = double.Parse(commandArgs[3]);
            string garbageType = commandArgs[4];

            
                var garbage = GarbageFactory.CreateWaste(garbageName, garbageWeight, garbageVolumePerKg, garbageType);

            if ((recyclingStation.RequredType == null || recyclingStation.RequredType != garbageType)
                ||WasteMeetsRequirements(recyclingStation))
            {

                var processingData = garbageProcessor.ProcessWaste(garbage);

                recyclingStation.Energy = recyclingStation.Energy + processingData.EnergyBalance;
                recyclingStation.Capital = recyclingStation.Capital + processingData.CapitalBalance;

                Console.WriteLine($"{garbage.Weight:F2} kg of {garbage.Name} successfully processed!");
            }
            else
            {
                Console.WriteLine("Processing Denied!");
            }
            
        }

        private bool WasteMeetsRequirements(RecyclingStation recyclingStation)
        {
            return recyclingStation.Energy > recyclingStation.RequiredEnergy
                   && recyclingStation.Capital > recyclingStation.RequiredCapital;
        }
    }
}
