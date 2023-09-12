using Console = System.Console;

namespace EmployeeDatabase;

public class Employee
{
    public string Name { get; set; }
    public int Wage { get; set; }

    public List<Employee> EmployeesList { get; set; }

    public Employee()
    {
        Name = string.Empty;
        EmployeesList = new List<Employee>();
    }

    public void AddEmployee(string name, int wage)
    {

        Employee employee = new Employee
        {
            Name = name,
            Wage = wage

        };

        EmployeesList.Add(employee);

        Console.WriteLine($"You have added {employee.Name} to the list.");
        Console.WriteLine("Push any key to continue.");
        Console.ReadKey();
    }
    public void ListEmployees()
    {
        int index = 0;
        Console.Clear();
        Console.WriteLine("This is the employee list!\n");

        foreach (var employee in EmployeesList)
        {
            index++;
            Console.WriteLine($"{index}. Employee: {employee.Name}, Wage: {employee.Wage}");
        }

        Console.WriteLine("\nPush any key to continue");
        Console.ReadKey();
    }

}