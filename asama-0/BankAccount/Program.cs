public class BankAccount
{
	public string Owner { get; set; }
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
}


public class Program
{
	public static void Main()
	{
		BankAccount bankAccount = new BankAccount("John Doe", -25m);
		Console.WriteLine(bankAccount.Balance);
		Console.WriteLine(bankAccount.Owner);
	}
}