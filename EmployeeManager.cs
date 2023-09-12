namespace EmployeeDatabase;

public class EmployeeManager
{
    private readonly List<Employee> employeeList = new List<Employee>();
    public void AddEmployee(string name, int wage)
    {

        Employee employee = new Employee
        {
            Name = name,
            Wage = wage

        };

        employeeList.Add(employee);

        Console.WriteLine($"You have added {employee.Name} to the list.");
        Console.WriteLine("Push any key to continue.");
        Console.ReadKey();
    }
    public void ListEmployees()
    {
        int index = 0;
        Console.Clear();
        Console.WriteLine("This is the employee list!\n");

        foreach (var employee in employeeList)
        {
            index++;
            Console.WriteLine($"{index}. Employee: {employee.Name}, Wage: {employee.Wage}");
        }

        Console.WriteLine("\nPush any key to continue");
        Console.ReadKey();
    }
}