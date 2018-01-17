namespace MyWallet.Test.Models
{
  public class Transfer
  {
    public Account AccountToWithdraw { get; private set; }
    public Account AccountToDeposit { get; private set; }
    public decimal Value { get; private set; }

    public Transfer(Account accountToWithdraw, Account accountToDeposit, decimal value)
    {
      AccountToWithdraw = accountToWithdraw;
      AccountToDeposit = accountToDeposit;
      Value = value;

      DoTransfer();
    }

    private void DoTransfer()
    {
      AccountToWithdraw.Withdraw(Value);
      AccountToDeposit.Deposit(Value);
      AccountToWithdraw.AddTransfer(this);
      AccountToDeposit.AddTransfer(this);
    }
  }
}