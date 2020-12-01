using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thince3a1
{
    public class Ex3aLoops
    {
        // 1) Initilize control variable
        // 2) Test Control variable with boolean expression
        // 3) Body of the loop, what calculation are we performing
        // 4) Change value of the control variable
        // 5) Show beginning and end of the loop is (Curly braces) " {} "

        //   public static string Calc0() 
        //{
        //    int i = 1, sum = 0;
        //    while ( i < 5)
        //    {
        //        sum += i;
        //        i++;
        //    }

        //    return sum.ToString();
        //}
        public static string Calc0(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate) // THIS IS WHILE LOOP
        {
            double futureValue = 0.0;
            try 
            { 
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                int i = 1;                                          // step 1 Initialize control variable
                while (i <= months)                                 // step 2 Test Control variable with boolean expression
                {
                futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate); // Step 3 Body of the loop, what calculations are we performing
                i++;   // step 4 Change control variable
                } // Show beginning and ending of the loop
        }
        catch 
        {
         return "Invalid input";
        }
            return futureValue.ToString("n2");
        }

        public static string Calc1(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate) // DO WHILE LOOP
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                int i = 1;                                          // step 1 Initialize control variable
                do                                                  // step 2 Test Control variable with boolean expression
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate); // Step 3 Body of the loop, what calculations are we performing
                    i++;                                           // step 4 Change control variable
                }                                                  // Show beginning and ending of the loop
                while (i <= months);
            }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
        }

        public static string Calc2(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate) // FOR loop
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);                                                      
                for(int i = 1; i <= months; i++)      //( int i = 1;) initialize and ( i <= months;) testing of condition // Changing value of control variable (I++)           
                { // beginning of the loop
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate); // Body of the loop    futureValue = (futureValue + monthlyPayment)
                } // ending of the loop
            }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
        }
        public static string Calc3(string strStart, string strEnd, string strIncrement)
        {
            string result = "";

            return result;
        }

        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";

            return result;
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";

            return result;
        }

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }
    }
}
