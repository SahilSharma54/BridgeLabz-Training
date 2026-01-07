namespace Models
{
    public abstract class Employee
    {
        protected int WagePerHour;
        protected int WorkingHours;

        protected Employee(int wagePerHour, int workingHours)
        {
            WagePerHour = wagePerHour;
            WorkingHours = workingHours;
        }

        public abstract int CalculateWage();
    }
}
