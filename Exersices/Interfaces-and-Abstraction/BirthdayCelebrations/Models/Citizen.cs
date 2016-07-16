using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations
{
    public class Citizen : Entity, IBirthday, IIdentifiable, IBuyer
    {
        public const int FoodCollectedByCitizen = 10;

        public Citizen(string name, string birthdate, string id, string age)
            : base(name)
        {
            this.Birthdate = birthdate;
            this.Id = id;
            this.Age = age;
            this.Food = 0;
        }

        public string Birthdate { get; set; }
        public string Id { get; set; }
        public string Age { get; set; }

        public void BuyFood()
        {
            this.Food += FoodCollectedByCitizen;
        }

        public int Food { get; set; }
    }
}
