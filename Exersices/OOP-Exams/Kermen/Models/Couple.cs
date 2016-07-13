using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kermen
{
    public abstract class Couple : HouseHold
    {
        private decimal tvCost;
        private decimal fridgeCost;

        protected Couple(decimal income, int numberOfRooms, decimal roomElectricity, decimal tvCost, decimal fridgeCost) 
            : base(income, numberOfRooms, roomElectricity)
        {
            this.TvCost = tvCost;
            this.FridgeCost = fridgeCost;
        }

        public decimal FridgeCost { get; set; }

        public decimal TvCost { get; set; }

        public override decimal Consumption => base.Consumption + this.TvCost + this.FridgeCost;

        public override int Population => 1 + base.Population;
    }
}