namespace MilitaryElite.Models
{
	public class Mission
	{

		private string codeName;
		private MissionStates state;

		public Mission(string codeName, MissionStates state)
		{
			this.CodeName = codeName;
			this.State = state;
		}

		public string CodeName
		{
			get { return this.codeName; }
			set { this.codeName = value; }
		}

		public MissionStates State
		{
			get { return this.state; }
			set { this.state = value; }
		}
	}
}
