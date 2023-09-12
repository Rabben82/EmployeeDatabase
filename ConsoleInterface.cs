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

                    string nameValid = validation.CheckIfStringIsValid(name);

                    Console.Write("What is the employees wage?: ");
                    string userInput = Console.ReadLine() ?? throw new InvalidOperationException();

                    if (userInput != null)
                    {
                        int wage = validation.CheckValidInputWage(userInput);

                        if (nameValid != null) employee.AddEmployee(nameValid, wage);
                    }

                    break;
                case 2:
                    employee.ListEmployees();
                    break;
            }

        } while (true);
    }
}