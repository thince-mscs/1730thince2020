using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace thince2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }
         
            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {             
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();             
           
            return result;
        }
        public static string DateCalc09(string currentDate, string dueDate) // minus dates 
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(currentDate);
                date = DateTime.Parse(dueDate);
                TimeSpan timeTillDue = dueDate - currentDate;
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc10(string currentDate, string dueDate) // use if and if else statements on #10
        {
            string result = "Invalid input";
            DateTime date;
                  
            try
            {
                date = DateTime.Parse(dueDate);
                date = DateTime.Parse(currentDate);
                result = date.ToShortDateString();
            }

            catch { }                  
            bool pastDue = false;
            if (currentDate > dueDate)
                pastDue = true;

            return result;
        }
    }
}