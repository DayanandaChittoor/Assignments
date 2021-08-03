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
            int dailyWage = 0;
            Random rand = new Random();
            int present = rand.Next(0, 2);
            Console.WriteLine(present);
            if (present == 1)
            {
                Console.WriteLine("Employee is Present!");
                dailyWage = perHourWage * HOURS_WORKED;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Daily Wage of Employee:" + dailyWage);
        }
    }
}
