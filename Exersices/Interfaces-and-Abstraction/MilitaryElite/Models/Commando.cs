using System.Collections.Generic;

namespace MilitaryElite.Models
{
	public class Commando : SpecialisedSoldier
	{
		public Commando(int id, string firstName, string lastName, double salary, CorpTypes corpType,List<Mission> missions) :
			base(id, firstName, lastName, salary, corpType)
		{
			this.Missions = missions;
		}

		public List<Mission> Missions { get; set; }
	}
}