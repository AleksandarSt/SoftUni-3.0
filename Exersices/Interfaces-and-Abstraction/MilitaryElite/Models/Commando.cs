using System.Collections.Generic;

namespace MilitaryElite.Models
{
	public class Commando : SpecialisedSoldier
	{
		private List<Mission> missions;

		public Commando(int id, string firstName, string lastName, double salary, CorpTypes corpType,List<Mission> missions) :
			base(id, firstName, lastName, salary, corpType)
		{
			this.Missions = missions;
		}

		public List<Mission> Missions { get; set; }

		public void CompleteMission(Mission mission)
		{
			mission.State=MissionStates.Finished;
		}
	}
}