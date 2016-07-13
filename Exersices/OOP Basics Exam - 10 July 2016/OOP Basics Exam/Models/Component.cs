namespace OOP_Basics_Exam
{
    public abstract class Component
    {
        protected Component(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get; set; }
        public string Type { get; set; }
    }
}