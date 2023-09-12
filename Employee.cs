using Console = System.Console;

namespace EmployeeDatabase;

public class Employee
{
    public string Name { get; set; }
    public int Wage { get; set; }

    public Employee()
    {
        Name = string.Empty;
    }
}