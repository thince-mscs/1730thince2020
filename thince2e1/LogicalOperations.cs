using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thince2e1
{
    class LogicalOperations
    {
        public static bool q01(decimal subtotal)
        {
            return subtotal >= 250 && subtotal < 500;
        }
        public static bool q02(int timeInService)
        {
            return timeInService <= 4 || timeInService >= 12;

        }
        public static bool q03(bool isValid, int years, int counter)
        {
            return isValid == true && counter++ < years;

        }
        public static bool q04(bool isValid, int years, int counter)
        {
            return isValid == true & counter++ < years;

        }
        public static bool q05(bool isValid, int years, int counter)
        {
            return isValid == true || counter++ < years;

        }
        public static bool q06(bool isValid, int years, int counter)
        {
            return isValid == true && counter++ < years;

        }
        public static bool q07(bool isValid, decimal date, decimal startDate, decimal expirationDate)
        {
            return date > startDate && date < expirationDate || isValid == true;

        }
        public static bool q08(decimal thisYTD, decimal lastYTD, int startYear, int currentYear, string empType)
        {
            return thisYTD > lastYTD || empType == "Part time" && startYear < currentYear;

        }
        public static bool q09(int years, int counter)
        {
            return !(counter++ >= years);

        }
        public static int q10(int a,int  b,int  c,int  d)
        {
            return a + b * c - d;

        }
    }
}
