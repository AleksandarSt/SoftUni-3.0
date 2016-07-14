using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
	class Startup
	{
		static void Main()
		{

			string input = Console.ReadLine();
			List<Entity> entities=new List<Entity>();
			List<IBirthday> birthdayEntities=new List<IBirthday>();

			while (input!="End")
			{
				string[] entityInfo = input.Split();
				string entityType = entityInfo[0];

				if (entityType==nameof(Citizen))
				{
					RegisterCitizen(entityInfo, birthdayEntities);
				}
				else if (entityType==nameof(Pet))
				{
					RegisterPet(entityInfo, birthdayEntities);
				}
				else if (entityType==nameof(Robot))
				{
					RegisterRobot(entityInfo, entities);
				}

				input = Console.ReadLine();
			}

			string year = Console.ReadLine();

			foreach (var entity in birthdayEntities)
			{
				if (entity.Birthdate.EndsWith(year))
				{
					Console.WriteLine(entity.Birthdate);
				}
			}
		}

		private static void RegisterRobot(string[] entityInfo, List<Entity> entities)
		{
			string name = entityInfo[1];
			string id = entityInfo[2];

			entities.Add(new Robot(name, id));
		}

		private static void RegisterPet(string[] entityInfo, List<IBirthday> entities)
		{
			string name = entityInfo[1];
			string birthdate = entityInfo[2];

			entities.Add(new Pet(name, birthdate));
		}

		private static void RegisterCitizen(string[] entityInfo, List<IBirthday> entities)
		{
			string name = entityInfo[1];
			string age = entityInfo[2];
			string id = entityInfo[3];
			string birthdate = entityInfo[4];

			entities.Add(new Citizen(name, birthdate, id, age));
		}
	}
}
