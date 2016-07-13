namespace Kermen
{
    public abstract class HouseHold
    {
        private int numberOfRooms;
        private decimal roomElectricity;
        private readonly decimal income;
        private decimal balance;

        protected HouseHold(decimal income, int numberOfRooms, decimal roomElectricity)
        {
            this.NumberOfRooms = numberOfRooms;
            this.RoomElectricity = roomElectricity;
            this.Income = income;
            this.Balance = 0;
        }

        public decimal Balance { get; set; }
        public decimal RoomElectricity { get; set; }
        public int NumberOfRooms { get; set; }
        public decimal Income { get; }
        public virtual int Population => 1;
        public virtual decimal Consumption => this.RoomElectricity*this.NumberOfRooms;

        public void GetIncome()
        {
            this.Balance += this.Income;
        }

        public void PayBills()
        {
            this.Balance -= this.Consumption;
        }

        public bool CanPayBils()
        {
            return this.Balance >= this.Consumption;
        }
    }
}