using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Basics_Exam
{
    public abstract class HardwareComponent : Component
    {
        protected HardwareComponent(string name, string type, int maximumCapacity, int maximumMemory) :
            base(name, type)
        {
            this.MaximumCapacity = maximumCapacity;
            this.MaximumMemory = maximumMemory;
            this.CurrentCapacity = 0;
            this.CurrentMemory = 0;
        }

        public virtual int MaximumCapacity { get; set; }
        public virtual int MaximumMemory { get; set; }
        public  int CurrentCapacity { get; set; }
        public  int CurrentMemory { get; set; }
        public Dictionary<string, SoftwareComponent> SoftwareComponents = new Dictionary<string, SoftwareComponent>();

        public void RegisterSoftwareComponent(SoftwareComponent softwareComponent)
        {
            if (CanBeRegistered(softwareComponent))
            {
                this.SoftwareComponents.Add(softwareComponent.Name, softwareComponent);
                this.CurrentCapacity += softwareComponent.CapacityConsumption;
                this.CurrentMemory += softwareComponent.MemoryConsumption;

            }
        }

        private bool CanBeRegistered(SoftwareComponent softwareComponent)
        {
            return this.CurrentCapacity + softwareComponent.CapacityConsumption <= this.MaximumCapacity
                   && this.CurrentMemory + softwareComponent.MemoryConsumption <= this.MaximumMemory;
        }

        public void DestroySoftwareComponent(SoftwareComponent softwareComponent)
        {
            if (SoftwareComponents.ContainsKey(softwareComponent.Name))
            {
                SoftwareComponents.Remove(softwareComponent.Name);
                this.CurrentCapacity -= softwareComponent.CapacityConsumption;
                this.CurrentMemory -= softwareComponent.MemoryConsumption;
            }
        }

        public override string ToString()
        {
            StringBuilder result=new StringBuilder();
            result.Append($"Hardware Component - {this.Name}");
            result.Append(Environment.NewLine);
            result.Append($"Express Software Components - {SoftwareComponents.Count(x => x.Value.Type == "Express")}");
            result.Append(Environment.NewLine);
            result.Append($"Light Software Components - {SoftwareComponents.Count(x => x.Value.Type == "Light")}");
            result.Append(Environment.NewLine);
            result.Append($"Memory Usage: {this.CurrentMemory} / {this.MaximumMemory}");
            result.Append(Environment.NewLine);
            result.Append($"Capacity Usage: {this.CurrentCapacity} / {this.MaximumCapacity}");
            result.Append(Environment.NewLine);
            result.Append($"Type: {this.Type}");
            result.Append(Environment.NewLine);
            result.Append(this.SoftwareComponents.Count != 0
                ? $"Software Components:{string.Join(",", this.SoftwareComponents.Keys)}"
                : $"Software Components: None");

            return result.ToString();
        }
    }
}