using RecyclingStation.WasteDisposal.Attributes;

namespace RecyclingStation.Models.GarbageModels
{
    [Burnable]
    class BurnableGarbage:Waste
    {
        public BurnableGarbage(string name, double volumePerKg, double weight) :
            base(name, volumePerKg, weight)
        {
        }
    }
}
