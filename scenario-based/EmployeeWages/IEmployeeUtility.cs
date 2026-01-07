namespace Utilities
{
    public interface IEmployeeUtility
    {
        bool CheckEmployeeAttendance();
        int CalculateMonthlyWage(int dailyWage, int workingDays);
        int CalculateWageTillCondition(int wagePerHour, int maxHours, int maxDays);
    }
}
