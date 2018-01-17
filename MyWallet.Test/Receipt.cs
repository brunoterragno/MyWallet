using System;

namespace MyWallet.Test
{
  public enum ReceiptType
  {
    Salary,
    Reward,
    Investment
  }

  public class Receipt
  {
    public ReceiptType Type { get; private set; }
    public decimal Value { get; private set; }
    public DateTime Date { get; private set; }

    public Receipt(ReceiptType type, decimal value, DateTime? date = null)
    {
      Type = type;
      Value = value;
      Date = date.HasValue ? date.Value : DateTime.Now;
    }
  }
}