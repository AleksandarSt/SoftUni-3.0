using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        private Dictionary<int, Private> army;

        public LeutenantGeneral(int id, string firstName, string lastName, double salary, Dictionary<int, Private> army)
            : base(id, firstName, lastName, salary)
        {
            this.Army = army;
        }

        public Dictionary<int, Private> Army
        {
            get { return army; }

            set { army = value; }
        }

        public override string ToString()
        {
            int counter = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(Environment.NewLine);
            sb.Append("Privates:");
            sb.Append(Environment.NewLine);
            sb.Append(string.Join(Environment.NewLine, this.Army.Values));
            
            return sb.ToString();
        }
    }
}