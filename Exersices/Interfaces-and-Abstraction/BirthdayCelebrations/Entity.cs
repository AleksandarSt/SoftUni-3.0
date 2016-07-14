namespace BirthdayCelebrations
{
	public abstract class Entity
	{
		protected Entity(string name)
		{
			this.Name = name;
		}

		public string Name { get; set; }
	}
}
