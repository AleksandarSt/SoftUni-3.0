using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
	public class Commando : SpecialisedSoldier,ICommando
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
			mission.State=MissionStates.finished;
		}

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.Append(Environment.NewLine);
            result.Append($"Corps: {this.CorpType}");
            result.Append(Environment.NewLine);
            result.Append($"Missions:");
            result.Append(Environment.NewLine);
            result.Append(string.Join(Environment.NewLine, this.Missions));

            return result.ToString();
        }
    }
}