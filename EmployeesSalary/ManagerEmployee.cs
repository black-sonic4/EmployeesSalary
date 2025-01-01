namespace EmployeesSalary
{
    internal class ManagerEmployee: Employee
    {
        public ManagerEmployee() {
            Type = EmployeeType.Manager;
        }

        public override double CalculateRateBaseSalary()
        {
            int totalMonths = Util.CalculateTotalMonthsFromToday(JoinDate);
            if (totalMonths >= 16)
                return 0.25;
            if (totalMonths >= 12)
                return 0.10;
            return 0.0;
        }

        public override double CalculateNewYearBonus()
        {
            int totalMonths = Util.CalculateTotalMonthsFromToday(JoinDate);
            return 100 * totalMonths + 0.1 * BaseSalary;
        }
    }
}
