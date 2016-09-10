using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Models
{
    public class ProcessingData:IProcessingData
    {
        private double energyBalance;
        private double capitalBalance;

        public ProcessingData(double energyBalance, double capitalBalance)
        {
            this.EnergyBalance = energyBalance;
            this.CapitalBalance = capitalBalance;
        }

        public double EnergyBalance
        {
            get { return this.energyBalance; }
            set { this.energyBalance = value; }
        }

        public double CapitalBalance
        {
            get { return this.capitalBalance; }
            set { this.capitalBalance = value; }
        }
    }
}
