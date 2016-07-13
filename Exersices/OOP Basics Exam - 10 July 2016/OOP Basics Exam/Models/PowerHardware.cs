﻿namespace OOP_Basics_Exam
{
    public class PowerHardware : HardwareComponent
    {
        public PowerHardware(string name, string type, int maximumCapacity, int maximumMemory) 
            : base(name, type, maximumCapacity, maximumMemory)
        {
        }

        public override int MaximumMemory => base.MaximumMemory+(base.MaximumMemory*3)/4;
        public override int MaximumCapacity => base.MaximumCapacity/4;


    }
}