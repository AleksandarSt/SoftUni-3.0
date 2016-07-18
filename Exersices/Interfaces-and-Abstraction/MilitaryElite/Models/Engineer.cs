using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, double salary, CorpTypes corpType,
            List<Repair> repairs)
            : base(id, firstName, lastName, salary, corpType)
        {
            this.Repairs = repairs;
        }

        public List<Repair> Repairs { get; set; }

        public override string ToString()
        {
            StringBuilder result =new StringBuilder();
            result.Append(base.ToString());
            result.Append(Environment.NewLine);
            result.Append($"Corps: {this.CorpType}");
            result.Append(Environment.NewLine);
            result.Append($"Repairs:");
            result.Append(Environment.NewLine);
	        result.Append(string.Join(Environment.NewLine, this.Repairs));

            return result.ToString();
        }
    }
}