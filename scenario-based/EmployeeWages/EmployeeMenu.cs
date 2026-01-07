using System;
using Models;
using Utilities;

namespace UI
{
    public class EmployeeMenu
    {
        public static void ShowMenu()
        {
            EmployeeUtility utility = new EmployeeUtility();

            Console.WriteLine("1. UC1 - Check Employee Attendance");
            Console.WriteLine("2. UC2 - Calculate Full Time Wage");
            Console.WriteLine("3. UC3 - Calculate Part Time Wage");
            Console.WriteLine("4. UC5 - Calculate Monthly Wage");
            Console.WriteLine("5. UC6 - Calculate Wage Till Condition");
            Console.WriteLine("0. Exit\n");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine(
                        utility.CheckEmployeeAttendance()
                        ? "Employee is Present"
                        : "Employee is Absent"
                    );
                    break;

                case 2:
                    Console.Write("Enter Wage Per Hour: ");
                    int ftWage = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Working Hours: ");
                    int ftHours = Convert.ToInt32(Console.ReadLine());

                    Employee fullTime = new FullTimeEmployee(ftWage, ftHours);
                    Console.WriteLine("Full Time Daily Wage: " + fullTime.CalculateWage());
                    break;

                case 3:
                    Console.Write("Enter Wage Per Hour: ");
                    int ptWage = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Working Hours: ");
                    int ptHours = Convert.ToInt32(Console.ReadLine());

                    Employee partTime = new PartTimeEmployee(ptWage, ptHours);
                    Console.WriteLine("Part Time Daily Wage: " + partTime.CalculateWage());
                    break;

                case 4:
                    Console.Write("Enter Daily Wage: ");
                    int dailyWage = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Working Days: ");
                    int workingDays = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(
                        "Monthly Wage: " +
                        utility.CalculateMonthlyWage(dailyWage, workingDays)
                    );
                    break;

                case 5:
                    Console.Write("Enter Wage Per Hour: ");
                    int wagePerHour = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Max Hours: ");
                    int maxHours = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Max Days: ");
                    int maxDays = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(
                        "Total Wage Till Condition: " +
                        utility.CalculateWageTillCondition(wagePerHour, maxHours, maxDays)
                    );
                    break;

                case 0:
                    Console.WriteLine("Thank You!");
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

            Console.WriteLine("\n-----------------------------------------\n");
            ShowMenu();
        }
    }
}
