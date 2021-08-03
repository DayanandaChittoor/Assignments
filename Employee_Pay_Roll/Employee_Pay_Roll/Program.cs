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
            int PART_TIME_HOURS = 4;
            int dailyWage = 0;
            Random rand = new Random();
            int workStatus = rand.Next(0, 3);
            Console.WriteLine(workStatus);
            ///Ctrl + R+R
            switch (workStatus)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    break;
                case 1:
                    Console.WriteLine("Employee is Present");
                    dailyWage = perHourWage * HOURS_WORKED;
                    break;
                case 2:
                    Console.WriteLine("Employee worked part time");
                    dailyWage = perHourWage * PART_TIME_HOURS;
                    break;
                default:
                    Console.WriteLine("Something Wrong Happened");
                    break;
            }
            Console.WriteLine("Total daily Wage earned " + dailyWage);
        }
    }
}
