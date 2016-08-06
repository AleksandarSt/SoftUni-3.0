using CS_OOP_Advanced_Exam_Prep_July_2016.Contracts;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Models.Shops
{
    class Mall:Shop
    {
        private const int Capacity = int.MaxValue;

        public Mall(IShop successor) : 
            base(Capacity, successor)
        {
        }
    }
}
