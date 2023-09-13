namespace EmployeeDatabase;

public class Validation
{
    private const int menuIndex = 3;
    private const int maxWage = 300000;
    public string CheckIfStringIsValid(string prompt)
    {
        Console.Clear();
        Console.Write(prompt);

        string userInput = Console.ReadLine() ?? throw new InvalidOperationException("Value can't be null");

        while (true)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Input can't be null or whitespace, enter a valid name");
                userInput = Console.ReadLine() ?? throw new InvalidOperationException("Value can't be null");
            }
            else if(int.TryParse(userInput, out int number))
            {
                Console.WriteLine("A number is not a valid name, enter a valid name with letters a-z ");
                userInput = Console.ReadLine() ?? throw new InvalidOperationException("Value can't be null");
            }
            else
            {
                return userInput;
            }
        }
    }

    public int CheckValidInputMenu()
    {
        do
        {
            string userInput = Console.ReadLine() ?? throw new InvalidOperationException("Value can't be null");

            if (!int.TryParse(userInput, out int numberMenu) || numberMenu is <= 0 or > menuIndex)
            {
                Console.WriteLine("Invalid input, you need to input that's in the range of the menu.");
            }
            else
            {
                return numberMenu;
            }

        } while (true);
    }

    public int CheckValidInputWage( string prompt)
    {
        Console.Write(prompt);
        string userInput = Console.ReadLine() ?? throw new InvalidOperationException("Value can't be null");

        do
        {

            if (!int.TryParse(userInput, out int numberWage) || numberWage <=0 || numberWage > maxWage)
            {
                Console.WriteLine("Invalid input, the wage cannot be 0 or moore than 300000kr");
                userInput = Console.ReadLine() ?? throw new InvalidOperationException("value can't be null");
            }
            else
            {
                return numberWage;
            }

        } while (true);
    }
}