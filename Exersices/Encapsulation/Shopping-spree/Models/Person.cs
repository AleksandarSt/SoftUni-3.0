using System;
using System.Collections.Generic;

namespace Shopping_spree.Models
{
    public class Person
    {
        private string name;
        private decimal money;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Basket=new List<Product>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public List<Product> Basket { get; set; }

        public void BuyProduct(Product product)
        {
            if (product.Money>this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }
                this.Money -= product.Money;
                this.Basket.Add(product);
        }

        public override string ToString()
        {
            string name = this.Name;

            string products = string.Join(", ", this.Basket);

            if (string.IsNullOrEmpty(products))
            {
                products = "Nothing bought";
            }

            string result = $"{name} - {products}";

            return result;
        }
    }
}
