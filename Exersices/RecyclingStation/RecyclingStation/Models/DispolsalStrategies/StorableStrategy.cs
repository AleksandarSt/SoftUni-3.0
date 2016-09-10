using RecyclingStation.WasteDisposal.Attributes;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Models.DispolsalStrategies
{
    [StorableAttribute]
    class StorableStrategy:GarbageDispolsalStrategy
    {
        public const double UsedEnergyCoeficient = 0.13;
        public const double UsedCapitalCoeficient = 0.13;

        public override IProcessingData ProcessGarbage(IWaste garbage)
        {
            var volume = garbage.Weight * garbage.VolumePerKg;

            this.EnergyUsed = volume*UsedEnergyCoeficient;
            this.CapitalUsed = volume*UsedCapitalCoeficient;

            return new ProcessingData(this.EnergyProduced - this.EnergyUsed, this.CapitalEarned - this.CapitalUsed);
        }
    }
}
