using RecyclingStation.WasteDisposal.Attributes;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.Models.GarbageModels
{
    [Disposable]
    abstract class Waste:IWaste
    {
        private string name;
        private double volumePerKg;
        private double weight;
        //private WasteTypes type;

        public Waste(string name, double volumePerKg, double weight)
        {
            this.Name = name;
            this.VolumePerKg = volumePerKg;
            this.Weight = weight;
            //this.Type = type;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double VolumePerKg
        {
            get { return this.volumePerKg; }
            set { this.volumePerKg = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
    

        //public WasteTypes Type
        //{
        //    get { return this.type; }
        //    set { this.type = value; }
        //}
    }
}
