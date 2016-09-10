using RecyclingStation.WasteDisposal.Attributes;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Models.DispolsalStrategies
{
    [BurnableAttribute]
    class BurnableStrategy:GarbageDispolsalStrategy
    {
        public const double UsedEnergyCoeficient = 0.2;

        public override IProcessingData ProcessGarbage(IWaste garbage)
        {
            var volume = garbage.Weight * garbage.VolumePerKg;

            this.EnergyProduced = volume;
            this.EnergyUsed = volume*UsedEnergyCoeficient;

            return new ProcessingData(this.EnergyProduced - this.EnergyUsed, this.CapitalEarned - this.CapitalUsed);
        }
    }
}
