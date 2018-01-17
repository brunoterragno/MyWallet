using System;

namespace MyWallet.Test.Models
{
  public enum ExpenseType
  {
    Purchase,
    House,
    Market,
    Leisure
  }

  public class Expense
  {
    public string Title { get; private set; }
    public ExpenseType Type { get; private set; }
    public decimal Value { get; private set; }
    public DateTime Date { get; private set; }

    public Expense(string title, ExpenseType type, decimal value, DateTime? date = null)
    {
      Title = title;
      Type = type;
      Value = value;
      Date = date.HasValue ? date.Value : DateTime.Now;
    }
  }
}