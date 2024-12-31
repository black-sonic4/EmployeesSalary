using EmployeesSalary;

Employee manager = new Employee()
{
    Name = "Ahmad",
    JoinDate = new DateOnly(2024, 1, 1),
    Type = EmployeeType.Manager,
    BaseSalary = 20000,
};


Employee salesman = new Employee()
{
    Name = "Mohamad",
    JoinDate = new DateOnly(2024, 10, 1),
    Type = EmployeeType.Salesman,
    BaseSalary = 10000,
};

Employee secretary = new Employee()
{
    Name = "Rami",
    JoinDate = new DateOnly(2024, 10, 1),
    Type = EmployeeType.Secretary,
    BaseSalary = 5000,
};

foreach (Employee employee in new[] { manager, salesman, secretary }) {
    Console.WriteLine("Employee " + employee.Name + "/" + employee.Type + ". Joined in: " + employee.JoinDate + " BaseSalary: " + employee.BaseSalary + ". Total Salary: " + employee.CalculateSalary());
}

manager.JoinDate = new DateOnly(2023, 10, 1);
salesman.JoinDate = new DateOnly(2024, 1, 1);
secretary.JoinDate = new DateOnly(2020, 1, 1);

Console.WriteLine("Afeter editing - 1:");

foreach (Employee employee in new[] { manager, salesman, secretary })
{
    Console.WriteLine("Employee " + employee.Name + "/" + employee.Type + ". Joined in: " + employee.JoinDate + " BaseSalary: " + employee.BaseSalary + ". Total Salary: " + employee.CalculateSalary());
}

manager.JoinDate = new DateOnly(2023, 1, 1);
salesman.JoinDate = new DateOnly(2024, 1, 1);
secretary.JoinDate = new DateOnly(2020, 1, 1);

Console.WriteLine("Afeter editing - 2:");

foreach (Employee employee in new[] { manager, salesman, secretary })
{
    Console.WriteLine("Employee " + employee.Name + "/" + employee.Type + ". Joined in: " + employee.JoinDate + " BaseSalary: " + employee.BaseSalary + ". Total Salary: " + employee.CalculateSalary());
}

Console.WriteLine("New year editing - 3:");
foreach (Employee employee in new[] { manager, salesman, secretary })
{
    Console.WriteLine("Employee " + employee.Name + "/" + employee.Type + ". Joined in: " + employee.JoinDate + " BaseSalary: " + employee.BaseSalary + ". Total Salary: " + employee.CalculateSalary());
}