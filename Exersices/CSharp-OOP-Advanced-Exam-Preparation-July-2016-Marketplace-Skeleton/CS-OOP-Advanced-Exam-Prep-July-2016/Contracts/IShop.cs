namespace CS_OOP_Advanced_Exam_Prep_July_2016.Contracts
{
    public interface IShop
    {
        int Capacity { get; set; }
        IShop Successor { get; }
    }
}
