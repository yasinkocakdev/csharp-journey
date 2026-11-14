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
			throw new ArgumentOutOfRangeException(nameof(amount), amount, "Deposit amount must be positive");
		
		Balance += amount;
		_transactions.Add(new Transaction("deposit", amount, DateTime.Now, Balance));	}

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
			Console.WriteLine($"{t.Date:dd.MM.yyyy HH:mm}  {t.Type}  {t.Amount}  → {t.BalanceAfter}");
		}
	}

public class Transaction
{
	public string Type { get; } //deposit or withdraw
	
	public decimal Amount { get; }
	public DateTime Date { get; }
	public decimal BalanceAfter{ get; }

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
		bankAccount.Deposit(50m);
		Console.WriteLine($"Bakiye: {bankAccount.Balance}");

		try
		{
        bankAccount.Withdraw(500m);
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Hata: {ex.Message}");
			
		}
		
		try
		{
			bankAccount.Withdraw(-10m);
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Hata: {ex.Message}");
 			
		}
		bankAccount.PrintHistory();  
	}	
}	
}