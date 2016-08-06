using CS_OOP_Advanced_Exam_Prep_July_2016.Contracts;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Models.Shops
{
    class Store:Shop
    {
        private const int Capacity = 15;

        public Store(IShop successor) 
            : base(Capacity,successor)
        {
        }
    }
}
