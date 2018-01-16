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

    public Receipt(ReceiptType type, decimal value)
    {
      this.Type = type;
      this.Value = value;
    }
  }
}