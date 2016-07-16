using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations.Models
{
    public class Rebel:Entity,IBuyer
    {
        public const int FoodCollectedByRebel = 5;

        public Rebel(string name, string age, string group) 
            : base(name)
        {
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }

        public string Age { get; set; }
        public string Group { get; set; }

        public void BuyFood()
        {
            this.Food += FoodCollectedByRebel;
        }

        public int Food { get; set; }
    }
}
