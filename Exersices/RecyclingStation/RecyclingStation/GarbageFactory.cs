using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecyclingStation.Models.GarbageModels;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation
{
    public class GarbageFactory
    {

        public static IWaste CreateWaste(string name, double weight, double volumePerKg,
            string type)
        {
            if (type== "Recyclable")
            {
                return new RecyclableGarbage(name,volumePerKg,weight);
            }
            else if(type== "Burnable")
            {
                return new BurnableGarbage(name,volumePerKg,weight);
            }
            else if (type== "Storable")
            {
                return new StorableGarbage(name,volumePerKg,weight);
            }
            else
            {
                throw new ArgumentException("Invalid type!");
            }
        }
    }
}
