namespace RecyclingStation
{
    class RecyclingStation
    {
        private double energy;
        private double capital;
        private double requiredEnergy;
        private double requiredCapital;
        private string requredType;

        public RecyclingStation()
        {
            this.Energy = 0;
            this.Capital = 0;
            this.RequiredCapital = 0;
            this.requiredEnergy = 0;
        }

        public double Energy
        {
            get
            {
                return energy;
            }

            set
            {
                energy = value;
            }
        }

        public double Capital
        {
            get
            {
                return capital;
            }

            set
            {
                capital = value;
            }
        }

        public double RequiredEnergy
        {
            get
            {
                return requiredEnergy;
            }

            set
            {
                requiredEnergy = value;
            }
        }

        public double RequiredCapital
        {
            get
            {
                return requiredCapital;
            }

            set
            {
                requiredCapital = value;
            }
        }

        public string RequredType
        {
            get
            {
                return requredType;
            }

            set
            {
                requredType = value;
            }
        }
    }
}
