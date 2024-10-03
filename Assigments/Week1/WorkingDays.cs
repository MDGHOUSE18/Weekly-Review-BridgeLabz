using System;
using System.Collections.Generic;
using System.Text;

namespace Reviews.Week1
{
    internal class WorkingDays
    {

        //Write a program that calculates the number of workdays (Monday to Friday) between two dates.  Saturday Sunday

        public static void noOfWorkingDays()
        {
            Console.Write("Enter the first date format(DD/MM/YYYY): ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the last date format(DD/MM/YYYY): ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            int workingDays = 0;

            for (DateTime date = date1; date <= date2; date = date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Saturday)
                {
                    workingDays++;
                }
            }

            Console.WriteLine("From " + date1.Date + " to " + date2.Date + " have " + workingDays + " working days");

        }
    }
}
