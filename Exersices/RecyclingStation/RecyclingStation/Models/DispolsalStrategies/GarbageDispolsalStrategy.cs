using RecyclingStation.WasteDisposal.Attributes;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Models.DispolsalStrategies
{
    [DisposableAttribute]
    abstract class GarbageDispolsalStrategy:IGarbageDisposalStrategy
    {
        private double energyProduced;
        private double energyUsed;
        private double capitalEarned;
        private double capitalUsed;

        protected GarbageDispolsalStrategy()
        {
            this.EnergyProduced = 0;
            this.EnergyUsed = 0;
            this.CapitalEarned = 0;
            this.CapitalUsed = 0;
        }

        public double EnergyProduced
        {
            get
            {
                return energyProduced;
            }

            set
            {
                energyProduced = value;
            }
        }

        public double EnergyUsed
        {
            get
            {
                return energyUsed;
            }

            set
            {
                energyUsed = value;
            }
        }

        public double CapitalEarned
        {
            get
            {
                return capitalEarned;
            }

            set
            {
                capitalEarned = value;
            }
        }

        public double CapitalUsed
        {
            get
            {
                return capitalUsed;
            }

            set
            {
                capitalUsed = value;
            }
        }

        public abstract IProcessingData ProcessGarbage(IWaste garbage);
    }
}
