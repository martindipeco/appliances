using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliances
{
    class WashingMachine : Appliance
    {
        private int loadKg;

        public WashingMachine()
        {
            loadKg = 5;
        }

        public WashingMachine(int loadKg)
        {
            this.loadKg = loadKg;
        }

        public int LoadKg
        {
            get { return loadKg; }
        }

        public override float FinalPrice()
        {
            base.CalculatePrice();

            if (loadKg > 30) 
            {
                this.basePrice = this.basePrice + 50;
            }
            return this.basePrice;
        }
    }
}
