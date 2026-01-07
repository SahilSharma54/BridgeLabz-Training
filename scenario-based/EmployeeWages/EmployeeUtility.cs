using System;

namespace Utilities
{
    public class EmployeeUtility : IEmployeeUtility
    {
        public bool CheckEmployeeAttendance()
        {
            Random random = new Random();
            return random.Next(0, 2) == 1;
        }

        public int CalculateMonthlyWage(int dailyWage, int workingDays)
        {
            return dailyWage * workingDays;
        }

        public int CalculateWageTillCondition(int wagePerHour, int maxHours, int maxDays)
        {
            int totalHours = 0;
            int totalDays = 0;

            while (totalHours < maxHours && totalDays < maxDays)
            {
                Console.Write($"Enter working hours for day {totalDays + 1}: ");
                int hours = Convert.ToInt32(Console.ReadLine());

                totalHours += hours;
                totalDays++;
            }

            return totalHours * wagePerHour;
        }
    }
}
