namespace EmployeesSalary
{
    internal class Employee
    {
        public string Name { get; set; }
        public int BaseSalary { get; set; }
        public string Type { get; set; }
        public DateOnly JoinDate {  get; set; }
        public int CalculateSalary()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);

            int totalMonths = ((today.Year - JoinDate.Year) * 12) + (today.Month - JoinDate.Month);
            double rate = 0.0;
            if (Type == "Manager")
            {
                if (totalMonths >= 12)
                    rate = 0.10;
                if (totalMonths >= 16)
                    rate = 0.25;
            }
            if (Type == "Salesman")
            {
                if (totalMonths >= 6)
                    rate = 0.01;
            }
            if (Type == "Secretary")
            {
                rate = 0.05;
            }
            return (int) Math.Floor(BaseSalary + rate * BaseSalary);
        }

    }
}
