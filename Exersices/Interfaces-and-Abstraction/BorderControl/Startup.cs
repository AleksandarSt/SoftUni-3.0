using System;
using System.Collections.Generic;

namespace BorderControl
{
	public class Startup
	{
		static void Main()
		{
			string input = Console.ReadLine();
			List<IEntity> intruders=new List<IEntity>();


			while (input!="End")
			{
				RegisterIntruder(input, intruders);

				input = Console.ReadLine();
			}

			input = Console.ReadLine();

			foreach (var intruder in intruders)
			{
				TryToDetainIntruder(intruder, input);
			}
		}

		private static void TryToDetainIntruder(IEntity intruder, string input)
		{
			if (intruder.Id.EndsWith(input))
			{
				Console.WriteLine(intruder.Id);
			}
		}

		private static void RegisterIntruder(string input, List<IEntity> intruders)
		{
			string[] intruderInfo = input.Split();

			if (intruderInfo.Length == 3)
			{
				string name = intruderInfo[0];
				string age = intruderInfo[1];
				string id = intruderInfo[2];

				intruders.Add(new Citizen(name, id, age));
			}
			else
			{
				string name = intruderInfo[0];
				string id = intruderInfo[1];

				intruders.Add(new Robot(name, id));
			}
		}
	}
}
