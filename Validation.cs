namespace EmployeeDatabase;

public class Validation
{
    public string CheckIfStringIsValid(string userInput)
    {
        while (true)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Input can't be null or whitespace, enter a valid name");
                userInput = Console.ReadLine() ?? throw new InvalidOperationException();
            }
            else if(int.TryParse(userInput, out int number))
            {
                Console.WriteLine("A number is not a valid name, enter a valid name with letters a-z ");
                userInput = Console.ReadLine() ?? throw new InvalidOperationException();
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
            string userInput = Console.ReadLine() ?? throw new InvalidOperationException();

            if (!int.TryParse(userInput, out int numberMenu) || numberMenu is <= 0 or > 3)
            {
                Console.WriteLine("Invalid input, you need to input that's in the range of the menu.");
            }
            else
            {
                return numberMenu;
            }

        } while (true);
    }

    public int CheckValidInputWage(string userInput)
    {
        do
        {

            if (!int.TryParse(userInput, out int numberWage) || numberWage <=0 || numberWage > 300000)
            {
                Console.WriteLine("Invalid input, the wage cannot be 0 or moore than 300000kr");
                userInput = Console.ReadLine() ?? throw new InvalidOperationException();
            }
            else
            {
                return numberWage;
            }

        } while (true);
    }
}