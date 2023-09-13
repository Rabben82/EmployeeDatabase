namespace EmployeeDatabase;

public class EmployeeManager
{
    private readonly List<Employee> employeeList = new List<Employee>();
    public void AddEmployee(string name, int wage)
    {

        employeeList.Add(new Employee(name, wage));

        Console.WriteLine($"You have added {name} to the list.");
        Console.WriteLine("Push any key to continue.");
        Console.ReadKey();
    }
    public void ListEmployees()
    {
        int index = 0;
        Console.Clear();
        Console.WriteLine("This is the employee list!\n");

        if (employeeList.Count == 0)
        {
            Console.WriteLine("You haven't added any employees");
        }
        else
        {
            foreach (var employee in employeeList)
            {
                index++;
                Console.WriteLine($"{index}. Employee: {employee.Name}, Wage: {employee.Wage}");
            }

        }

        Console.WriteLine("\nPush any key to continue");
        Console.ReadKey();
    }
}