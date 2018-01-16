using System;
using System.Collections.Generic;

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

    private List<Expense> Expenses { get; set; }
    public List<Expense> GetExpenses { get { return Expenses.Clone(); } }
    private List<Receipt> Receipts { get; set; }
    public List<Receipt> GetReceipts { get { return Receipts.Clone(); } }
    private List<Transfer> Transfers { get; set; }
    public List<Transfer> GetTransfers { get { return Transfers.Clone(); } }

    public Account(string name, AccountType type, decimal initialBalance = 0)
    {
      this.Name = name;
      this.Type = type;
      this.Balance = initialBalance;
      this.Expenses = new List<Expense>();
      this.Receipts = new List<Receipt>();
      this.Transfers = new List<Transfer>();
    }

    public void ChangeName(string newName)
    {
      this.Name = newName;
    }

    public void ChangeType(AccountType newType)
    {
      this.Type = newType;
    }

    public void AddExpense(Expense newExpense)
    {
      Balance -= newExpense.Value;
      this.Expenses.Add(newExpense);
    }

    public void AddReceipt(Receipt newReceipt)
    {
      Balance += newReceipt.Value;
      this.Receipts.Add(newReceipt);
    }

    public void AddTransfer(Transfer newTransfer)
    {
      this.Transfers.Add(newTransfer);
    }

    public void Withdraw(decimal value)
    {
      if (Balance < value)
        throw new InvalidOperationException("Not enough money to withdraw");

      Balance -= value;
    }

    public void Deposit(decimal value)
    {
      Balance += value;
    }
  }
}