namespace MyWallet.Test
{
  public enum AccountType
  {
    Checking,
    Saving
  }

  public class Account
  {
    public string Name { get; private set; }
    public AccountType Type { get; private set; }
    public decimal Balance { get; private set; }

    public Account(string name, AccountType type, decimal initialBalance = 0)
    {
      this.Name = name;
      this.Type = type;
      this.Balance = initialBalance;
    }

    public void ChangeName(string newName)
    {
      this.Name = newName;
    }

    public void ChangeType(AccountType newType)
    {
      this.Type = newType;
    }
  }
}