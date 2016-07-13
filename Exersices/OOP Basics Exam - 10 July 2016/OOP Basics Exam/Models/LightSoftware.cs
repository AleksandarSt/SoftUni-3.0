using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_Exam
{
    public class LightSoftware : SoftwareComponent
    {
        public LightSoftware(string name, string type, int capacityConsumption, int memoryConsumption) 
            : base(name, type, capacityConsumption, memoryConsumption)
        {
        }

        public override int MemoryConsumption => base.MemoryConsumption/2;
        public override int CapacityConsumption => base.CapacityConsumption + base.CapacityConsumption/2;
    }
}