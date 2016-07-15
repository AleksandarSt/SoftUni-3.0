using System.Collections.Generic;

namespace MilitaryElite.Models
{
	public class LeutenantGeneral : Private
	{
		public LeutenantGeneral(int id, string firstName, string lastName, double salary) 
			: base(id, firstName, lastName, salary)
		{
		}

		public Dictionary<int, Private> Army;
	}
}