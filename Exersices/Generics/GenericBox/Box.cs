using System;

namespace GenericBox
{
    public class Box<T> where T:IComparable<T>
    {
        private T value;

        public Box()
            :this(default(T))
        {
            
        }

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get { return this.value; } set { this.value = value; } }

        public override string ToString()
        {
            return $"{this.value.GetType().FullName}: {this.value}";
        }
    }
}
