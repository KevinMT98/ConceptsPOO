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


Console.WriteLine(employee1);
Console.WriteLine(employee2);