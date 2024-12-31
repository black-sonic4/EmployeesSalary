using System.Diagnostics;
using EmployeesSalary;

void test_manager()
{
    Util.GetToday = () => new DateOnly(2024, 7, 1); // Mock date

    Employee manager = new Employee()
    {
        Name = "Ahmad",
        JoinDate = new DateOnly(2024, 6, 1),
        Type = EmployeeType.Manager,
        BaseSalary = 20000,
    };
    Debug.Assert(manager.CalculateSalary() == 20000);
    manager.JoinDate = new DateOnly(2023, 6, 1);
    Debug.Assert(manager.CalculateSalary() == 22000);
    manager.JoinDate = new DateOnly(2023, 1, 1);
    Debug.Assert(manager.CalculateSalary() == 25000);

    Util.GetToday = () => new DateOnly(2025, 1, 1); // Mock date
    Debug.Assert(manager.CalculateSalary() == 29400);
}

void test_salesman()
{
    Util.GetToday = () => new DateOnly(2024, 7, 1); // Mock date

    Employee salesman = new Employee()
    {
        Name = "Ahmad",
        JoinDate = new DateOnly(2024, 6, 1),
        Type = EmployeeType.Salesman,
        BaseSalary = 20000,
    };
    Debug.Assert(salesman.CalculateSalary() == 20000);
    salesman.JoinDate = new DateOnly(2023, 6, 1);
    Debug.Assert(salesman.CalculateSalary() == 20200);
    salesman.JoinDate = new DateOnly(2023, 1, 1);
    Debug.Assert(salesman.CalculateSalary() == 20200);

    Util.GetToday = () => new DateOnly(2025, 1, 1); // Mock date
    Debug.Assert(salesman.CalculateSalary() == 20800);
}


void test_secretary()
{
    Util.GetToday = () => new DateOnly(2024, 7, 1); // Mock date

    Employee secretary = new Employee()
    {
        Name = "Ahmad",
        JoinDate = new DateOnly(2024, 6, 1),
        Type = EmployeeType.Secretary,
        BaseSalary = 20000,
    };
    Debug.Assert(secretary.CalculateSalary() == 21000);
    secretary.JoinDate = new DateOnly(2023, 6, 1);
    Debug.Assert(secretary.CalculateSalary() == 21000);
    secretary.JoinDate = new DateOnly(2023, 1, 1);
    Debug.Assert(secretary.CalculateSalary() == 21000);
    
    Util.GetToday = () => new DateOnly(2025, 1, 1); // Mock date
    Debug.Assert(secretary.CalculateSalary() == 21600);
}

test_manager();
test_salesman();
test_secretary();
Util.GetToday = () => DateOnly.FromDateTime(DateTime.Now);


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