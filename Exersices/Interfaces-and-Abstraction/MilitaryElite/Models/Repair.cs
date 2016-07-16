namespace MilitaryElite.Models
{
	public class Repair
	{
		private string partName;
		private int hoursWorker;

		public Repair(string partName, int hoursWorker)
		{
			this.PartName = partName;
			this.HoursWorker = hoursWorker;
		}

		public string PartName
		{
			get { return this.partName; }
			set { this.partName = value; }
		}

		public int HoursWorker
		{
			get { return this.hoursWorker; }
			set { this.hoursWorker = value; }
		}
	}
}
