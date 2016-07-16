namespace MilitaryElite.Models
{
	public class Spy : Soldier
	{
		private int codeNumber;

		public Spy(int id, string firstName, string lastName, int codeNumber)
			: base(id, firstName, lastName)
		{
			this.CodeName = codeNumber;
		}

		public int CodeName
		{
			get { return this.codeNumber; }
			set { this.codeNumber = value; }
		}
	}
}