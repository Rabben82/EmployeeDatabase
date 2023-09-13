﻿namespace EmployeeDatabase;

public class ConsoleInterface
{
    readonly Validation validation = new Validation();
    private readonly EmployeeManager employeeManager = new EmployeeManager();

    public void Start()
    {
        do
        {
            Menu();

            int numberMenu = validation.CheckValidInputMenu();

            switch (numberMenu)
            {
                case 1:
                    AddEmployee();
                    break;
                case 2:
                    employeeManager.ListEmployees();
                    break;
                case 3:
                    Exit();
                    break;
            }

        } while (true);
    }

    private void Menu()
    {
        Console.Clear();
        Console.WriteLine("What do you wanna do today?\n");
        Console.WriteLine("1. Add new employee.");
        Console.WriteLine("2. Show employee list.");
        Console.WriteLine("3. Quit!");
    }
    private void AddEmployee()
    {
        string nameValid = validation.CheckIfStringIsValid("What is the employees name?:");
        int wage = validation.CheckValidInputWage("What is the employees wage?: ");
        employeeManager.AddEmployee(nameValid, wage);
    }

    private void Exit()
    {
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }
}