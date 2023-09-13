using Console = System.Console;

namespace EmployeeDatabase;

public class Employee
{
    public string Name { get; set; }
    public int Wage { get; set; }

    public Employee(string name, int wage)
    {
        Name = name;
        Wage = wage;
    }
}