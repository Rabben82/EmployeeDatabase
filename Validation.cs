namespace EmployeeDatabase;

public class Validation
{
    public int CheckValidInputMenu()
    {
        do
        {
            string userInput = Console.ReadLine() ?? throw new InvalidOperationException();

            if (!int.TryParse(userInput, out int numberMenu) || numberMenu is <= 0 or > 2)
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