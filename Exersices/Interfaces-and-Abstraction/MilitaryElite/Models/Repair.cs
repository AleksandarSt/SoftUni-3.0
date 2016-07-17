using System.Text;

namespace MilitaryElite.Models
{
	public class Repair
	{
		private string partName;
		private int repairHours;

		public Repair(string partName, int repairHours)
		{
			this.PartName = partName;
			this.RepairHours = repairHours;
		}

		public string PartName
		{
			get { return this.partName; }
			set { this.partName = value; }
		}

		public int RepairHours
		{
			get { return this.repairHours; }
			set { this.repairHours = value; }
		}

	    public override string ToString()
	    {
            StringBuilder result=new StringBuilder();
	        result.Append($"Part Name: {this.PartName} Hours Worked: {this.RepairHours}");

	        return result.ToString();
	    }
	}
}
