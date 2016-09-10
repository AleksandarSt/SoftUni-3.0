using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CS_OOP_Advanced_Exam_Prep_July_2016.Contracts;
using CS_OOP_Advanced_Exam_Prep_July_2016.Models.Products;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Models.Shops
{
    public abstract class Shop:IShop
    {
        private int capacity;
        private readonly IShop successor;
        private ICollection<IProduct> products;

        protected Shop(int capacity, IShop successor)
        {
            this.Capacity = capacity;
            this.successor = successor;
            this.products=new List<IProduct>();
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

        public void AddProduct(IProduct product)
        {
            if (this.Capacity<this.products.Sum(x=>x.Size)+product.Size)
            {
                this.successor.AddProduct(product);
                return;
            }

            this.products.Add(product);
        }
    }
}
