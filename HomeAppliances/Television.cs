using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliances
{
    class Television : Appliance
    {
        private int inches;
        private bool tuner;

        public Television() 
        {
            inches = 20;
            tuner = false;
        }

        public Television(float price, float weightKg)
        {
            this.basePrice = price;
            this.weightKg = weightKg;
        }

        public Television(int inches, bool tuner)
        {
            this.inches = inches;
            this.tuner = tuner;
        }

        public int Inches
        {
            get { return inches; }
        }

        public bool Tuner
        {
            get { return tuner; }
        }

        public override float FinalPrice()
        {
            base.CalculatePrice();

            if (inches > 40)
            {
                this.basePrice = this.basePrice + (this.basePrice * 0.3f);
            }
            if (tuner)
            {
                this.basePrice = this.basePrice + (this.basePrice * 0.5f);
            }
            return this.basePrice;
        }
    }
}
