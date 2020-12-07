using System;

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
        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {      
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

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

        //public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, out decimal futureValue) // FOR loop
        //{         
        //    for (int i = 0; i < months; i++)
        //    {
        //        futureValue = (futureValue
        //                       + monthlyInvestment) * (1 + monthlyInterestRate);
        //    }        
        //}
        //public static double FahrenheitToCelsius(double fahrenheit)
        //{

        //    celsius = (fahrenheit * 9 / 5) + 32;
        //    {
        //       return FahrenheitToCelsius
        //    }
        //}

        public static void CelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
           
            fahrenheit = (celsius - 32) * 5 / 9;
            {
                
            }


        }
        public static decimal GrossPay(decimal hours, decimal payRate) // if statment is hours are less t han or equal to 40 take hours * rate
                                                                       // if hours are more than 40 pay then overtime (40 * rate) + hours - 40 * rate * 1.5
        {
            decimal GrossPay = 0m;

            if (hours <= 40m)
                payRate = 10m;
            else if
                (hours > 40m)
                payRate = 10m * 1.5m;

            return GrossPay;
        }

            public static decimal TotalHours(string strNumbers)
            {
                decimal total = 0m;
                int startIndex = 0;

                while (startIndex < strNumbers.LastIndexOf(" "))
            {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    Decimal number = Decimal.Parse(strNumber);
                    total += number;
                    startIndex = endIndex + 1;
            }

                return total;
            }
        
    }
}
