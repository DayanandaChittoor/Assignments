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
            if (workStatus == 1)
            {
                Console.WriteLine("Employee is Present!");
                dailyWage = perHourWage * HOURS_WORKED;
            }
            else if (workStatus == 2)
            {
                Console.WriteLine("Employee worked for part time");
                dailyWage = perHourWage * PART_TIME_HOURS;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Daily Wage of Employee:" + dailyWage);
        }
    }
}
