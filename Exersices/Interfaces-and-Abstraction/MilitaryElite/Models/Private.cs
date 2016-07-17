using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
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

        public override string ToString()
        {
            string result = $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}";

            return result;
        }
    }
}