using System;

class EmployeeUtility : IEmployeeUtility
{
    // UC1
    public void UC1_CheckAttendance()
    {
        Random random = new Random();
        int attendance = random.Next(0, 2);

        Console.WriteLine(
            attendance == 1 ? "Employee is Present" : "Employee is Absent"
        );
    }

    // UC2 - Full Time Daily Wage
    public void UC2_FullTimeDailyWage()
    {
        Console.Write("Enter wage per hour: ");
        int wagePerHour = Convert.ToInt32(Console.ReadLine());

        int fullTimeHours = 8;

        Employee employee = new Employee(wagePerHour, fullTimeHours);
        Console.WriteLine("Full Time Daily Wage: " + employee.CalculateWage());
    }

    // UC3 - Part Time Daily Wage
    public void UC3_PartTimeDailyWage()
    {
        Console.Write("Enter wage per hour: ");
        int wagePerHour = Convert.ToInt32(Console.ReadLine());

        int partTimeHours = 4;

        Employee employee = new Employee(wagePerHour, partTimeHours);
        Console.WriteLine("Part Time Daily Wage: " + employee.CalculateWage());
    }

    // UC4 - Switch Case
    public void UC4_WorkingHoursSwitch()
    {
        Console.WriteLine("1 - Full Time");
        Console.WriteLine("2 - Part Time");
        Console.WriteLine("0 - Absent");

        Console.Write("Enter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        int hours;
        switch (choice)
        {
            case 1: hours = 8; break;
            case 2: hours = 4; break;
            default: hours = 0; break;
        }

        Console.WriteLine("Working Hours: " + hours);
    }

    // UC5 - Monthly Wage
    public void UC5_MonthlyWage()
    {
        Console.Write("Enter daily wage: ");
        int dailyWage = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter working days: ");
        int days = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Monthly Wage: " + (dailyWage * days));
    }

    // UC6 - Wage Till Condition
    public void UC6_WageTillCondition()
    {
        Console.Write("Enter wage per hour: ");
        int wagePerHour = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter max hours: ");
        int maxHours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter max days: ");
        int maxDays = Convert.ToInt32(Console.ReadLine());

        int totalHours = 0;
        int days = 0;

        while (totalHours < maxHours && days < maxDays)
        {
            totalHours += 8;
            days++;
        }

        Console.WriteLine("Total Wage: " + (totalHours * wagePerHour));
    }
}
