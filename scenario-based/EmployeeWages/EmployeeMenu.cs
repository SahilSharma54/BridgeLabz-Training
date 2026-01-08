using System;

class EmployeeMenu
{
    static IEmployeeUtility utility = new EmployeeUtility();

    public static void ShowMenu()
    {
        Console.WriteLine("Press 1 - Check Attendance");
        Console.WriteLine("Press 2 - Daily Wage (Full Time)");
        Console.WriteLine("Press 3 - Part Time Wage");
        Console.WriteLine("Press 4 - Switch Case Working Hours");
        Console.WriteLine("Press 5 - Monthly Wage");
        Console.WriteLine("Press 6 - Wage Till Condition");
        Console.WriteLine("Press 7 - Exit\n");

        Console.Write("Enter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        switch (choice)
        {
            case 1: 
            utility.UC1_CheckAttendance(); 
            break;

            case 2: 
            utility.UC2_FullTimeDailyWage(); 
            break;

            case 3: 
            utility.UC3_PartTimeDailyWage(); 
            break;

            case 4: 
            utility.UC4_WorkingHoursSwitch(); 
            break;

            case 5: 
            utility.UC5_MonthlyWage(); 
            break;

            case 6: 
            utility.UC6_WageTillCondition(); 
            break;
            
            case 0:
                Console.WriteLine("Thank You!");
                return;
            default:
                Console.WriteLine("Invalid Choice!");
                break;
        }

        Console.WriteLine("\n-----------------------------\n");
        ShowMenu();
    }
}
