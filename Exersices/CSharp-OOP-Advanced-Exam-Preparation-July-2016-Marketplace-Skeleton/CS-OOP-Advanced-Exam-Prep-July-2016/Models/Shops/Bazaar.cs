using CS_OOP_Advanced_Exam_Prep_July_2016.Contracts;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Models.Shops
{
    class Bazaar:Shop
    {
        public const int Capacity = 30;

        public Bazaar(IShop successor) 
            : base(Capacity, successor)
        {
        }
    }
}
