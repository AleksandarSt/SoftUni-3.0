using System.ComponentModel;

namespace MilitaryElite.Models
{
	public enum MissionStates
	{
		[Description("inProgress")]
		inProgress,
		[Description("Finished")]
		finished
	}
}