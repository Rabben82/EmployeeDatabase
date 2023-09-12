using Console = System.Console;

namespace EmployeeDatabase;

public class Employee
{
    public string Name { get; set; }
    public int Wage { get; set; }

    public void ListEmployees(List<Employee> employees)
    {
        int index = 0;
        Console.Clear();
        Console.WriteLine("This is the employee list!\n");

        foreach (var employee in employees)
        {
            index++;
            Console.WriteLine($"{index}. Employee: {employee.Name}, Wage: {employee.Wage}");
        }

        Console.WriteLine("\nPush any key to continue");
        Console.ReadKey();
    }

}