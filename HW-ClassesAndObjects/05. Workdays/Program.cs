// Write a method that calculates the number of workdays between today and given date, passed as parameter. 
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Workdays
{
    class Program
    {

        private static int WorkDaysBetweenTodayAndDate(DateTime futureDate)
        {
            List<DateTime> holidays = new List<DateTime>();
            holidays.Add(DateTime.Parse("09-02-2013"));
            holidays.Add(DateTime.Parse("09-03-2013"));
            holidays.Add(DateTime.Parse("09-04-2013"));

            DateTime Today = DateTime.Now;
            TimeSpan period = futureDate-Today;
            int span = period.Days;
            span = span - span / 7 * 2;

            foreach (DateTime holiday in holidays)
            {
                if (holiday > Today && holiday < futureDate) span--;
            }

            return span;
        }

        static void Main(string[] args)
        {
            DateTime date = DateTime.Parse("10-1-2013");
            int workDays = WorkDaysBetweenTodayAndDate(date);
            Console.WriteLine("Workdays {0}",workDays);

        }
    }
}
