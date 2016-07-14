namespace BorderControl
{
	public class Citizen : IEntity
	{
		public Citizen(string name, string id, string age)
		{
			this.Name = name;
			this.Id = id;
			this.Age = age;
		}

		public string Age { get; set; }

		public string Name { get; set; }

		public string Id { get; set; }
	}
}
