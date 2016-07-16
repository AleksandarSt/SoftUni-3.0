using System.ComponentModel;

namespace MilitaryElite.Models
{
	public enum MissionStates
	{
		[Description("inProgress")]
		InProgress,
		[Description("Finished")]
		Finished
	}
}