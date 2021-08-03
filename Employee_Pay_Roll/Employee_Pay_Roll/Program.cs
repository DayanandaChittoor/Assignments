using System;

namespace Employee_Pay_Roll
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int present = rand.Next(0, 2);
            if (present == 1)
            {
                Console.WriteLine("Employee is Present!");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
