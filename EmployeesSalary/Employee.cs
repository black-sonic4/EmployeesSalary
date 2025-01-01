namespace EmployeesSalary
{
    enum EmployeeType
    {
        Manager,
        Salesman,
        Secretary,
        Something
    }
    internal class Employee
    {
        public string Name { get; set; }
        public int BaseSalary { get; set; }
        public EmployeeType Type { get; protected set; }
        public DateOnly JoinDate {  get; set; }
        public int CalculateSalary()
        {
            double rate = CalculateRateBaseSalary();
            double allowance = CalculateAllowance();
            double new_year_bonus = CalculateNewYearBonus();
            
            double total_salary_without_new_year_bonus = (rate + 1.0) * BaseSalary + allowance;
            
            if (Util.GetToday().Month == 1)
                return (int)Math.Floor(new_year_bonus + total_salary_without_new_year_bonus);
            
            return (int)Math.Floor(total_salary_without_new_year_bonus);
        }

        public virtual double CalculateRateBaseSalary()
        {
            return 0.0;
        }
        public virtual double CalculateAllowance()
        {
            return 0.0;
        }

        public virtual double CalculateNewYearBonus()
        {
            return 0.0;
        }

    }
}
