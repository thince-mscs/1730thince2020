using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thince3b1
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;

            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;


            return discountPercent;
        }
        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months) // FOR loop
        {
            decimal futureValue = 0m;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }
        public static double FahrenheitToCelsius(double Fahrenheit, double Celsius);
        {         
            double celsius = 36;

                fahrenheit = (celsius - 32) * 5 / 9;
        


            return celsius;


    }
}
