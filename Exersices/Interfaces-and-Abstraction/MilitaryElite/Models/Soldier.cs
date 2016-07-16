namespace MilitaryElite.Models
{
	public abstract class Soldier
	{
		private int id;
		private string firstName;
		private string lastName;

		protected Soldier(int id, string firstName, string lastName)
		{
			this.Id = id;
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		public string FirstName
		{
			get
			{
				return this.firstName;
			}
			set
			{
				this.firstName = value;
			}
		}

		public string LastName
		{
			get
			{
				return this.lastName;
			}
			set
			{
				this.lastName = value;
			}
		}
	}
}