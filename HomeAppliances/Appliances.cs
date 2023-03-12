using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliances
{
    abstract class Appliance
    {
        protected float basePrice;
        protected string color;
        protected char efficiency;
        protected float weightKg; 

        public Appliance() 
        {
            basePrice = 100;
            color = "white";
            efficiency = 'f';
            weightKg = 5;
        }

        public Appliance(float basePrice, float weight)
        {
            this.basePrice = basePrice;
            this.weightKg = weight;
            this.color = "white";
            this.efficiency = 'f';
        }

        public Appliance(float basePrice, string color, char efficiency, float weight)
        {
            this.basePrice = basePrice;
            this.color = color;
            this.efficiency = efficiency;
            this.weightKg = weight;
        }

        public float BasePrice
        {
            get { return basePrice; }
        }

        public string Color
        {
            get { return color; }
        }

        public char Efficiency
        {
            get { return efficiency; }
        }

        public float WeightKg
        {
            get { return weightKg; }
        }

        private void CheckEfficiency(char letter)
        {
            //TODO: case sensitive
            char[] validChars = { 'a', 'b', 'c', 'd', 'e', 'f' };
            foreach (char c in validChars)
            {
                if (c == letter)
                {
                    break;
                }
                else
                {
                    letter = 'f';
                }
            }
        }

        private void CheckColor(string color)
        {
            string[] validColors = { "white", "black", "red", "blue", "grey" };
            foreach (string c in validColors)
            {
                if (c == color.ToLower())
                {
                    break;
                }
                else
                {
                    color = "white";
                }
            }
        }

        protected void CalculatePrice()
        {
            int letterPrice = 0;
            int weightPrice;

            switch (efficiency)
            {
                case 'a':
                    letterPrice = 100;
                    break;

                case 'b':
                    letterPrice = 80;
                    break;

                case 'c':
                    letterPrice = 60;
                    break;

                case 'd':
                    letterPrice = 50;
                    break;

                case 'e':
                    letterPrice = 30;
                    break;

                case 'f':
                    letterPrice = 10;
                    break;
                default:
                    break;
            }

            //TODO add a try catch for 0 or negative weights
            if (weightKg >= 0 && weightKg <= 19)
            {
                weightPrice = 10;
            }
            else if (weightKg >= 20 && weightKg <= 49)
            {
                weightPrice = 50;
            }
            else if (weightKg >= 50 && weightKg <= 79)
            {
                weightPrice = 80;
            }
            else
            {
                weightPrice = 100;
            }

            basePrice = letterPrice + weightPrice;
        }

        public abstract float FinalPrice();
    }
}
