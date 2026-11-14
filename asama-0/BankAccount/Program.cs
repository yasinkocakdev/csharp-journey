public class BankAccount
{
    private List<Transaction> _transactions = new List<Transaction>();

    public string Owner { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner, decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialBalance), initialBalance, "Initial balance cannot be negative");
        }

        Owner = owner;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), amount, "Deposit amount must be positive");
        }

        Balance += amount;
        _transactions.Add(new Transaction("deposit", amount, DateTime.Now, Balance));
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), amount, "Withdraw amount must be positive");
        }

        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds");
        }

        Balance -= amount;
        _transactions.Add(new Transaction("withdraw", amount, DateTime.Now, Balance));
    }

    public void PrintHistory()
    {
        foreach (Transaction t in _transactions)
        {
            Console.WriteLine($"{t.Date:dd.MM.yyyy HH:mm}  {t.Type}  {t.Amount}  -> {t.BalanceAfter}");
        }
    }
}

public class Transaction
{
    public string Type { get; }
    public decimal Amount { get; }
    public DateTime Date { get; }
    public decimal BalanceAfter { get; }

    public Transaction(string type, decimal amount, DateTime date, decimal balanceAfter)
    {
        Type = type;
        Amount = amount;
        Date = date;
        BalanceAfter = balanceAfter;
    }
}

public class Program
{
    public static void Main()
    {
        BankAccount bankAccount = new BankAccount("John Doe", 100m);
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("1) Deposit  2) Withdraw  3) Balance  4) History  0) Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                    {
                        try
                        {
                            bankAccount.Deposit(depositAmount);
                            Console.WriteLine($"Deposited. Balance: {bankAccount.Balance}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number");
                    }
                    break;

                case "2":
                    Console.Write("Amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                    {
                        try
                        {
                            bankAccount.Withdraw(withdrawAmount);
                            Console.WriteLine($"Withdrawn. Balance: {bankAccount.Balance}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number");
                    }
                    break;

                case "3":
                    Console.WriteLine($"Balance: {bankAccount.Balance}");
                    break;

                case "4":
                    bankAccount.PrintHistory();
                    break;

                case "0":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}