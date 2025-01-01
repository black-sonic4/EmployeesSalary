namespace EmployeesSalary
{
    internal class SecretaryEmployee: Employee
    {
        public SecretaryEmployee()
        {
            Type = EmployeeType.Secretary;
        }

        public override double CalculateRateBaseSalary()
        {
            return 0.05;
        }

        public override double CalculateNewYearBonus()
        {
            int totalMonths = Util.CalculateTotalMonthsFromToday(JoinDate);
            return 25 * totalMonths;
        }
    }
}
