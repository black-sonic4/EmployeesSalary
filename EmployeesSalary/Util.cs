namespace EmployeesSalary
{
    internal class Util
    {
        public static int CalculateTotalMonthsBetween(DateOnly startDate, DateOnly endDate)
        {
            int yearDifference = endDate.Year - startDate.Year;
            int monthDifference = endDate.Month - startDate.Month;
            return (yearDifference * 12) + monthDifference;
        }
        public static int CalculateTotalMonthsFromToday(DateOnly date)
        {
            return CalculateTotalMonthsBetween(date, GetToday());
        }
        public static Func<DateOnly> GetToday = () => DateOnly.FromDateTime(DateTime.Now);

    }
}
