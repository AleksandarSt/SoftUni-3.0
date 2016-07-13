using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kermen
{
    public class AloneYoung : Single
    {
        private const int NumberOfRooms = 1;
        private const decimal RoomElectricity = 10;

        public decimal laptopCost;

        public AloneYoung(decimal salary, decimal laptopCost)
            : base(salary, NumberOfRooms, RoomElectricity)
        {
            this.laptopCost = laptopCost;
        }

        public override decimal Consumption => base.Consumption + this.laptopCost;
    }
}