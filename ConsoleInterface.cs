namespace EmployeeDatabase;

public class ConsoleInterface
{
    Validation validation = new Validation();
    private Employee employee = new Employee();

    public void StartConsole()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("What do you wanna do today?\n");
            Console.WriteLine("1. Add new employee.");
            Console.WriteLine("2. Show employee list.");

            int numberMenu = validation.CheckValidInputMenu();

            switch (numberMenu)
            {
                case 1:
                    Console.Clear();

                    Console.Write("What is the employees name?: ");
                    string name = Console.ReadLine() ?? throw new InvalidOperationException();

                    Console.Write("What is the employees wage?: ");
                    string userInput = Console.ReadLine() ?? throw new InvalidOperationException();

                    if (userInput != null)
                    {
                        int wage = validation.CheckValidInputWage(userInput);

                        if (name != null) employee.AddEmployee(name, wage);
                    }

                    break;
                case 2:
                    employee.ListEmployees();
                    break;
            }

        } while (true);
    }
}