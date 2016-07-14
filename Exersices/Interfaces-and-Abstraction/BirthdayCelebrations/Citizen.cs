namespace BirthdayCelebrations
{
	public class Citizen : Entity, IBirthday, IIdentifiable
	{

		public Citizen(string name, string birthdate, string id, string age)
			: base(name)
		{
			Birthdate = birthdate;
			Id = id;
			Age = age;
		}

		public string Birthdate { get; set; }
		public string Id { get; set; }
		public string Age { get; set; }
	}
}
