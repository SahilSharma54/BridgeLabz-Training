class Employee
{
    private int wagePerHour;
    private int workingHours;

    public Employee(int wagePerHour, int workingHours)
    {
        this.wagePerHour = wagePerHour;
        this.workingHours = workingHours;
    }

    public int CalculateWage()
    {
        return wagePerHour * workingHours;
    }
}
