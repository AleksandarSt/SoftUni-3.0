namespace BirthdayCelebrations
{
	public class Robot : Entity, IIdentifiable
	{
		public Robot(string name, string id)
			: base(name)
		{
			this.Id = id;
		}

		public string Id { get; }
	}
}
