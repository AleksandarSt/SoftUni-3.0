namespace BorderControl
{
	public class Robot : IEntity
	{
		public Robot(string name, string id)
		{
			this.Name = name;
			this.Id = id;
		}

		public string Name { get; }
		public string Id { get; }
	}
}
