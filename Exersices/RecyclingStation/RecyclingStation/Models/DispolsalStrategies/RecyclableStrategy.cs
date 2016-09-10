using RecyclingStation.WasteDisposal.Attributes;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Models.DispolsalStrategies
{
    [RecyclableAttribute]
    class RecyclableStrategy:GarbageDispolsalStrategy
    {
        private const int GarbagePricePerKg = 400;
        private const double UsedEnergyCoeficient = 0.5;

        public override IProcessingData ProcessGarbage(IWaste garbage)
        {
            var volume = garbage.Weight*garbage.VolumePerKg;

            this.EnergyUsed = volume*UsedEnergyCoeficient;
            this.CapitalEarned = garbage.Weight*GarbagePricePerKg;
            
            return new ProcessingData(this.EnergyProduced - this.EnergyUsed, this.CapitalEarned - this.CapitalUsed);
        }
    }
}
