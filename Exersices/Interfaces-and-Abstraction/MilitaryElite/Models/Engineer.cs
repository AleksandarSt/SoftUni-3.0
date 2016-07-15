using System.Collections.Generic;

namespace MilitaryElite.Models
{
	public class Engineer : SpecialisedSoldier
	{
		public Engineer(int id, string firstName, string lastName, double salary, CorpTypes corpType, List<Repair> repairs)
			: base(id, firstName, lastName, salary, corpType)
		{
			this.Repairs = repairs;
		}

		public List<Repair> Repairs { get; set; }
	}
}