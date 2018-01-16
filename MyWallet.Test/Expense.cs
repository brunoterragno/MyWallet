namespace MyWallet.Test
{
  public enum ExpenseType
  {
    Purchase
  }

  public class Expense
  {
    public string Title { get; private set; }
    public ExpenseType Type { get; private set; }
    public decimal Value { get; private set; }

    public Expense(string title, ExpenseType type, decimal value)
    {
      this.Title = title;
      this.Type = type;
      this.Value = value;
    }
  }
}