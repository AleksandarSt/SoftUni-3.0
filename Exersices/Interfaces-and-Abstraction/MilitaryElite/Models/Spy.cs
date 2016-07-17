using System;
using System.Text;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
	public class Spy : Soldier,ISpy
	{
		private int codeNumber;

		public Spy(int id, string firstName, string lastName, int codeNumber)
			: base(id, firstName, lastName)
		{
			this.CodeNumber = codeNumber;
		}

		public int CodeNumber
        {
			get { return this.codeNumber; }
			set { this.codeNumber = value; }
		}

	    public override string ToString()
	    {
            StringBuilder result=new StringBuilder();
	        result.Append($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
	        result.Append(Environment.NewLine);
	        result.Append($"Code Number: {this.CodeNumber}");
            
            return result.ToString();
	    }
	}
}