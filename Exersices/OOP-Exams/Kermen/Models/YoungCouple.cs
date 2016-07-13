using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kermen
{
    public class YoungCouple : Couple
    {
        private const int NumberOfRooms = 2;
        private const decimal RoomElectricity = 20;

        private decimal laptopCost;

        public YoungCouple(decimal salaryOne, decimal salaryTwo, decimal tvCost,
            decimal fridgeCost, decimal laptopCost) :
                base(salaryOne + salaryTwo, NumberOfRooms, RoomElectricity, tvCost, fridgeCost)
        {
            this.LaptopCost = laptopCost;
        }

        protected YoungCouple(int numberOfRooms, decimal roomElectricity, decimal income, decimal tvCost,
            decimal fridgeCost, decimal laptopCost)
            :base(income,numberOfRooms,roomElectricity,tvCost,fridgeCost)
        {
            this.LaptopCost = laptopCost;
        }

        public decimal LaptopCost { get; set; }

        public override decimal Consumption => base.Consumption + this.LaptopCost*2;
    }
}