namespace OOP_Basics_Exam
{
    public abstract class SoftwareComponent : Component
    {
        protected SoftwareComponent(string name, string type,int capacityConsumption, int memoryConsumption) : 
            base(name, type)
        {
            this.CapacityConsumption = capacityConsumption;
            this.MemoryConsumption = memoryConsumption;
        }

        public virtual int CapacityConsumption { get; set; }
        public virtual int MemoryConsumption { get; set; }
    }
}