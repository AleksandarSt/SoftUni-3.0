namespace BirthdayCelebrations
{
	public class Pet:Entity,IBirthday
	{
		public Pet(string name, string birthdate) 
			: base(name)
		{
			this.Birthdate = birthdate;
		}

		public string Birthdate { get; }
	}
}
