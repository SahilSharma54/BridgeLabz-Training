namespace Models
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(int wagePerHour, int workingHours)
            : base(wagePerHour, workingHours)
        {
        }

        public override int CalculateWage()
        {
            return WagePerHour * WorkingHours;
        }
    }
}
