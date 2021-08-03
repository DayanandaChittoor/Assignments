using System;

namespace Employee_Pay_Roll
{
    class Program
    {
        static void Main(string[] args)
        {
            //DailyWage Calculation
            int perHourWage = 1000;
            int HOURS_WORKED = 8;
            int MAX_WORKING_DAYS = 20;
            int PART_TIME_HOURS = 4;
            int wagePerDay = 0; 
            ///int totalWorkingDays = 0;
            int monthlyWage = 0;
           
            ///Ctrl + R+R
            ///for (i=0; i<=20; i++)
            ///while (totalWorkingDays <= MAX_WORKING_DAYS)
            for (int i=1; i<=MAX_WORKING_DAYS; i++)
            {
                Random rand = new Random();
                int workStatus = rand.Next(0, 3);
                Console.WriteLine(workStatus);
                switch (workStatus)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        wagePerDay = 0;
                        break;
                    case 1:
                        Console.WriteLine("Employee is Present");
                        wagePerDay = perHourWage * HOURS_WORKED;
                        break;
                    case 2:
                        Console.WriteLine("Employee worked part time");
                        wagePerDay = perHourWage * PART_TIME_HOURS;
                        break;
                    default:
                        Console.WriteLine("Something Wrong Happened");
                        break;
                }
                ///totalWorkingDays++;
                Console.WriteLine("Daily wage earned " + wagePerDay);
                monthlyWage = monthlyWage + wagePerDay;
            }
            Console.WriteLine("Total Wage per month earned " + monthlyWage);
        }
    }
}
