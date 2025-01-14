namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instance of the BankAccount class
            BankAccount account = new BankAccount();

            // User to deposit money
            Console.Write("Enter an amount to deposit: ");
            string input = Console.ReadLine();

            // Input can convert to a double
            bool isValidAmount = double.TryParse(input, out double depositAmount);

            // If the amount is valid and greater than 0
            if (isValidAmount && depositAmount > 0)
            {
                account.Deposit(depositAmount);
                Console.WriteLine($"You have successfully deposited: {depositAmount:C}.");
            }
            else
            {
                // Invalid input or non-positive amount
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }

            // User can see the balance
            double balance = account.GetBalance();
            Console.WriteLine($"Your current balance is: {balance:C}.");
        }
    }
}
