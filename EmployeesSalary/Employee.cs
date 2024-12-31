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
        public EmployeeType Type { get; set; }
        public DateOnly JoinDate {  get; set; }
        public int CalculateSalary()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);

            int totalMonths = ((today.Year - JoinDate.Year) * 12) + (today.Month - JoinDate.Month);
            double rate = 0.0;
            if (Type == EmployeeType.Manager)
            {
                if (totalMonths >= 12)
                    rate = 0.10;
                if (totalMonths >= 16)
                    rate = 0.25;
            }
            if (Type == EmployeeType.Salesman)
            {
                if (totalMonths >= 6)
                    rate = 0.01;
            }
            if (Type == EmployeeType.Secretary)
            {
                rate = 0.05;
            }
            return (int) Math.Floor(BaseSalary + rate * BaseSalary);
        }

        public double CalculateBouns ()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            int totalMonths = (today.Year - JoinDate.Year) * 12 + (today.Month - JoinDate.Month);
            double addedMoney = 0.0;
            if(Type == EmployeeType.Manager)
            {
                addedMoney = (100 * totalMonths) + (0.1 * BaseSalary);
            }
            if(Type == EmployeeType.Salesman || Type == EmployeeType.Secretary)
            {
                addedMoney = (25 * totalMonths);
            }
            return BaseSalary + addedMoney;
           
        }

    }
}
