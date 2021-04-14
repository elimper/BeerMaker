using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerLibrary
{
    public class BeerUtility
    {
        private const decimal UTILIZATION_NUMBER = 1.34m;
        private decimal calculateUtilization(decimal gravity, int minutesInBoil)
        {
            int choice = 0;
            if (gravity <= 1.040m)
            {
                choice = 1;
            }
            else if (gravity <= 1.070m)
            {
                choice = 2;
            }
            else if (gravity <= 1.130m)
            {
                choice = 3;
            }
            else
            {
                choice = 4;
            }
            switch (choice) {
                case (1):
                    if (minutesInBoil > 50)
                    {
                        return 30;
                    }
                    else if(minutesInBoil > 40)
                    {
                        return 21;
                    }
                    else if( minutesInBoil > 30)
                    {
                        return 18;
                    }
                    else if(minutesInBoil > 20)
                    {
                        return 15;
                    }
                    else if(minutesInBoil > 10)
                    {
                        return 10;
                    }
                    else
                    {
                        return 5;
                    }
                case (2):
                    if (minutesInBoil > 50)
                    {
                        return 20.0m;
                    }
                    else if (minutesInBoil > 40)
                    {
                        return 18.0m;
                    }
                    else if (minutesInBoil > 30)
                    {
                        return 15.0m;
                    }
                    else if (minutesInBoil > 20)
                    {
                        return 10.5m;
                    }
                    else if (minutesInBoil > 10)
                    {
                        return 7.0m;
                    }
                    else
                    {
                        return 2;
                    }
                case (3):
                    if (minutesInBoil > 50)
                    {
                        return 23;
                    }
                    else if (minutesInBoil > 40)
                    {
                        return 21;
                    }
                    else if (minutesInBoil > 30)
                    {
                        return 12;
                    }
                    else if (minutesInBoil > 20)
                    {
                        return 8;
                    }
                    else if (minutesInBoil > 10)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                case (4):
                    if (minutesInBoil > 50)
                    {
                        return 20;
                    }
                    else if (minutesInBoil > 40)
                    {
                        return 18;
                    }
                    else if (minutesInBoil > 30)
                    {
                        return 10;
                    }
                    else if (minutesInBoil > 20)
                    {
                        return 6;
                    }
                    else if (minutesInBoil > 10)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1.5m;
                    }
                default:
                    return decimal.MinusOne;
            }
        }

        public decimal calculateIBU(decimal gallons, decimal alphaAcidPercentage, decimal hopWeightOz, decimal gravity, int minutesInBoil)
        {
            return (hopWeightOz * alphaAcidPercentage * calculateUtilization(gravity, minutesInBoil))
                / (gallons * UTILIZATION_NUMBER);
        }

        public decimal gravityPoints(string fermentableName, decimal weightInPounds, decimal gallons, int efficiency)
        {
            decimal efficiencyModifier = Convert.ToDecimal(efficiency) / 100;
            return (((getExtractPotential(fermentableName) * weightInPounds) * efficiencyModifier) / gallons);
        }
        private decimal getExtractPotential(string name)
        {
            name = name.ToLower();
            if (name.Contains("pale"))
            {
                return 38;
            }
            else if (name.Contains("caramel") || name.Contains("crystal"))
            {
                return 34;
            }
            else if(name.Contains("dark") || name.Contains("roasted"))
            {
                return 26;
            }
            else if (name.Contains("lme"))
            {
                return 38;
            }else if (name.Contains("dme"))
            {
                return 40;
            }
            else if (name.Contains("sugar"))
            {
                return 46;
            }
            else
            {
                return decimal.MinusOne;
            }
        }
    }
}
