using System;
using RecyclingStation.WasteDisposal;

namespace RecyclingStation
{
    public class RecyclingStationMain
    {
        private static void Main()
        {
            var recyclingStation=new RecyclingStation();
            var garbageProcessor=new GarbageProcessor();
            var commandProcessor=new CommandProcessor(recyclingStation,garbageProcessor);

            var command = Console.ReadLine();

            while (command != "TimeToRecycle")
            {
                commandProcessor.ProccesCommand(command);

                command = Console.ReadLine();
            }
        }
    }
}
