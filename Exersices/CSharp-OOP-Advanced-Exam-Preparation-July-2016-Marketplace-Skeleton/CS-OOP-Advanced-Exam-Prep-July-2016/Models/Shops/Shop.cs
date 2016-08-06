using CS_OOP_Advanced_Exam_Prep_July_2016.Contracts;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Models.Shops
{
    public abstract class Shop:IShop
    {
        private int capacity;
        private readonly IShop successor;

        protected Shop(int capacity, IShop successor)
        {
            this.Capacity = capacity;
            this.successor = successor;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                this.capacity = value;
            }
        }

        public IShop Successor => this.successor;
    }
}
