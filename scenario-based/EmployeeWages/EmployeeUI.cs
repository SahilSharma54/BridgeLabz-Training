using System;

namespace UI
{
    public class EmployeeUI
    {
        public static void StartApplication()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine(" Employee Wage Computation Application ");
            Console.WriteLine("=========================================\n");

            EmployeeMenu.ShowMenu();
        }
    }
}
