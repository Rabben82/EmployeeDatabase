using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmployeeDatabase
{
    public class ConsoleInterface
    {

    }

    internal class Program
    {
        private static List<Employee> employeesList = new List<Employee>();
        private static Employee employee = new Employee();
        private static int numberMenu;
        private static int numberWage;
        private static string userInput;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("What do you wanna do today?\n");
                Console.WriteLine("1. Add new employee.");
                Console.WriteLine("2. Show employee list.");

                CheckValidInputMenu();

                switch (numberMenu)
                {
                    case 1:
                        Console.Clear();

                        Console.Write("What is the employees name?: ");
                        string name = Console.ReadLine();

                        Console.Write("What is the employees wage?: ");
                        userInput = Console.ReadLine();

                        int wage = CheckValidInputWage();

                        AddEmployee(name, wage);
                        break;
                    case 2:
                        employee.ListEmployees(employeesList);
                        break;
                }

            } while (true);



        }

        public static void AddEmployee(string name, int wage)
        {

            Employee employee = new Employee
            {
                Name = name,
                Wage = wage

            };

            employeesList.Add(employee);

            Console.WriteLine($"You have added {employee.Name} to the list.");
            Console.WriteLine("Push any key to continue.");
            Console.ReadKey();
        }

        public static void CheckValidInputMenu()
        {
            do
            {
                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out numberMenu) || numberMenu is <= 0 or > 2)
                {
                    Console.WriteLine("Invalid input, you need to input that's in the range of the menu.");
                }
                else
                {
                    break;
                }

            } while (true);
        }

        public static int CheckValidInputWage()
        {
            do
            {
               

                if (!int.TryParse(userInput, out numberWage) || numberWage is <= 0 or > 300000)
                {
                    Console.WriteLine("Invalid input, the wage cannot be 0 or moore than 300000kr");
                    userInput = Console.ReadLine();
                }
                else
                {
                    return numberWage;
                }

            } while (true);

        }
    }
}