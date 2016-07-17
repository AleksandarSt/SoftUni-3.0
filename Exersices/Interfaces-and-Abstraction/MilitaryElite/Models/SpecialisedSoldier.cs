using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private CorpTypes corpType;

        protected SpecialisedSoldier(int id, string firstName, string lastName, double salary, CorpTypes corpType)
            : base(id, firstName, lastName, salary)
        {
            this.CorpType = corpType;
        }

        public CorpTypes CorpType
        {
            get { return this.corpType; }
            set { this.corpType = value; }
        }

    }
}