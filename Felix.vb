public class BankAccount
{
    private decimal _balance;

    // Read-only property
    public decimal Balance => _balance;

    public BankAccount(decimal initialBalance = 0)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative");
        _balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive");
        
        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive");

        if (amount > _balance)
            throw new InvalidOperationException("Insufficient funds - overdraft not allowed");

        _balance -= amount;
    }
}

  // Read-only getter
  double get balance => _balance;

  BankAccount([this._balance = 0]) {
    if (_balance < 0) throw ArgumentError('Balance cannot be negative');
    )
  }

  void deposit(double amount) {
    if (amount <= 0) throw ArgumentError('Amount must be positive');
    _balance += amount;
    )
  }

  void withdraw(double amount) {
    if (amount <= 0) throw ArgumentError('Amount must be positive');
    )
    if (amount > _balance) throw Exception('Insufficient funds');
    )_
    balance -= amount;
  }