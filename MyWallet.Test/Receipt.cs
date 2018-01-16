using System;

namespace MyWallet.Test
{
  public enum ReceiptType
  {
    Salary
  }

  public class Receipt
  {
    public ReceiptType Type { get; private set; }
    public decimal Value { get; private set; }
    public DateTime Date { get; private set; }

    public Receipt(ReceiptType type, decimal value, DateTime? date = null)
    {
      this.Type = type;
      this.Value = value;
      this.Date = date.HasValue ? date.Value : DateTime.Now;
    }
  }
}