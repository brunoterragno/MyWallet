using System;

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
    public DateTime Date { get; private set; }

    public Expense(string title, ExpenseType type, decimal value, DateTime? date = null)
    {
      this.Title = title;
      this.Type = type;
      this.Value = value;
      this.Date = date.HasValue ? date.Value : DateTime.Now;
    }
  }
}