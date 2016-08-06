using CS_OOP_Advanced_Exam_Prep_July_2016.Contracts;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Models.Products
{
    abstract class Product:IProduct
    {
        private string name;
        private int size;

        public Product(string name, int size)
        {
            this.Name = name;
            this.Size = size;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public virtual int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
    }
}
