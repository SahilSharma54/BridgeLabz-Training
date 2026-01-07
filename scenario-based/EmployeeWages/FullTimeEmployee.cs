namespace Models
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int wagePerHour, int workingHours)
            : base(wagePerHour, workingHours)
        {
        }

        public override int CalculateWage()
        {
            return WagePerHour * WorkingHours;
        }
    }
}
