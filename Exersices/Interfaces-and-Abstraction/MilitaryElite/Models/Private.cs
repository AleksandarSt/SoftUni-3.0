namespace MilitaryElite.Models
{
	public class Private : Soldier
	{
		private double salary;

		public Private(int id, string firstName, string lastName, double salary)
			: base(id, firstName, lastName)
		{
			this.Salary = salary;
		}

		public double Salary
		{
			get { return this.salary; }
			set { this.salary = value; }
		}
	}
}