using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace WorkdaysNumber
{
    class WorkdaysNumber
    {

        static void Main(string[] args)
        {
            /*
            05. Write a method that calculates the number of workdays between today and given date, passed as parameter. 
            Consider that workdays are all days from Monday to Friday except a fixed list of public holidays
            specified preliminary as array.
            */

            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            DateTime[] publicHolidays = 
            {
                new DateTime(2013,1,1),
                new DateTime(2013,2,6),
                new DateTime(2013,3,28),
                new DateTime(2013,5,1),
                new DateTime(2013,6,1),
                new DateTime(2013,9,6),
                new DateTime(2013,12,31),
                new DateTime(2013,12,30)
            };

            DateTime[] workingSaturdays = 
            {          
                new DateTime(2013,12,7),
                new DateTime(2013,12,21),
                new DateTime(2013,02,9)
            };
          
            try
            {
                Console.WriteLine("Write an end date:");
                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Month: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Day: ");
                int day = int.Parse(Console.ReadLine());
            
                DateTime endDate = new DateTime(year, month, day);
                Console.WriteLine("The number of working days to {0} is {1}!", endDate, GetNumberOfWorkingDaysToDate(endDate, publicHolidays, workingSaturdays));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static int GetNumberOfWorkingDaysToDate(DateTime endDate, DateTime[] publicHolidays, DateTime[] workingSaturdays)
        {
            int counter = 0;
            DateTime currentDay = DateTime.Now.Date;

            for (DateTime date = currentDay; date <= endDate; date.AddDays(1))
            {
                if ((date <= endDate) &&
                   (Array.IndexOf(publicHolidays, date) == -1) &&
                   ((Array.IndexOf(workingSaturdays, date) != -1) || (date.DayOfWeek.ToString() != "Saturday")) &&
                   (date.DayOfWeek.ToString() != "Sunday"))
                {

                    counter++;
                }
                date = date.AddDays(1);
            }
            return counter;
        }

    }
}
