using RecyclingStation.WasteDisposal.Attributes;

namespace RecyclingStation.Models.GarbageModels
{
    [Recyclable]
    class RecyclableGarbage:Waste
    {
        public RecyclableGarbage(string name, double volumePerKg, double weight) : 
            base(name, volumePerKg, weight)
        {
        }
    }
}
