using ConceptsPOO;

Console.WriteLine("...");
Console.WriteLine("...");

Employee employee1 = new SalaryEmployee()
{
    id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDay = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M
};
Employee employee2 = new CommissionEmployee()
{
    id = 2020,
    FirstName = "Carolina",
    LastName = "gutierrez",
    BirthDay = new Date(1998, 5, 23),
    HiringDate = new Date(2022, 2, 15),
    IsActive = true,
    sales = 320000000M,
    CommissionPercentaje = 0.03F
};
Employee employee3 = new HourlyEmployee()
{
    id = 2020,
    FirstName = "HORAS",
    LastName = "gutierrez",
    BirthDay = new Date(1998, 5, 23),
    HiringDate = new Date(2022, 2, 15),
    IsActive = true,
    Hours = 235,
    HourVlaue = 5531.92M
};
Employee employee4 = new BaseCommissionEmployee()
{
    id = 2020,
    FirstName = "base mas comision",
    LastName = "gutierrez",
    BirthDay = new Date(1998, 5, 23),
    HiringDate = new Date(2022, 2, 15),
    IsActive = true,
    Base = 1300000,
    sales = 56000000M,
    CommissionPercentaje= 0.015F
    
};


//Console.WriteLine(employee1);
//Console.WriteLine(employee2);
//Console.WriteLine(employee3);
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                               ===============");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "Iphone 15 Pro MAX",
    Price = 5300000M,
    Quantity = 6
};
Invoice invoice2 = new Invoice()
{
    Description = "Picanha",
    Price = 32000M,
    Quantity = 17.5f
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);


