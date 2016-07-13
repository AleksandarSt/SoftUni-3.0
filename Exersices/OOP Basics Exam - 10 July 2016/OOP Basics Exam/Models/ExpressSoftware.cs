using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_Exam
{
    public class ExpressSoftware : SoftwareComponent
    {
        public ExpressSoftware(string name, string type, int capacityConsumption, int memoryConsumption) 
            : base(name, type, capacityConsumption, memoryConsumption)
        {
        }

        public override int MemoryConsumption => base.MemoryConsumption*2;
    }
}