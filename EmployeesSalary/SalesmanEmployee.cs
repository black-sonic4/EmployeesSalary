namespace EmployeesSalary
{
    internal class SalesmanEmployee: Employee
    {
        public SalesmanEmployee()
        {
            Type = EmployeeType.Salesman;
        }

        public override double CalculateRateBaseSalary()
        {
            int totalMonths = Util.CalculateTotalMonthsFromToday(JoinDate);
            if (totalMonths >= 6)
                return 0.01;
            return 0.0;
        }

        public override double CalculateNewYearBonus()
        {
            int totalMonths = Util.CalculateTotalMonthsFromToday(JoinDate);
            return 25 * totalMonths;
        }
    }
}
