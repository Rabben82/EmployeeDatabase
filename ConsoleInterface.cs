namespace EmployeeDatabase;

public class ConsoleInterface
{
    readonly Validation validation = new Validation();
    private readonly EmployeeManager employeeManager = new EmployeeManager();

    public void Start()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("What do you wanna do today?\n");
            Console.WriteLine("1. Add new employee.");
            Console.WriteLine("2. Show employee list.");
            Console.WriteLine("3. Quit!");

            int numberMenu = validation.CheckValidInputMenu();

            switch (numberMenu)
            {
                case 1:
                    Console.Clear();

                    Console.Write("What is the employees name?: ");
                    string name = Console.ReadLine() ?? throw new InvalidOperationException("value can't be null");

                    string nameValid = validation.CheckIfStringIsValid(name);
                    Console.Write("What is the employees wage?: ");

                    string userInput = Console.ReadLine() ?? throw new InvalidOperationException("value can't be null");
                    int wage = validation.CheckValidInputWage(userInput);

                    employeeManager.AddEmployee(nameValid, wage);
                    break;
                case 2:
                    employeeManager.ListEmployees();
                    break;
                case 3:
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
            }

        } while (true);
    }
}