using System;
using System.Collections.Generic;

namespace MyWallet.Test.Models
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

    private List<Expense> Expenses { get; set; } = new List<Expense>();
    public List<Expense> GetExpenses { get { return Expenses.Clone(); } }
    private List<Receipt> Receipts { get; set; } = new List<Receipt>();
    public List<Receipt> GetReceipts { get { return Receipts.Clone(); } }
    private List<Transfer> Transfers { get; set; } = new List<Transfer>();
    public List<Transfer> GetTransfers { get { return Transfers.Clone(); } }

    public Account(string name, AccountType type, decimal initialBalance = 0)
    {
      Name = name;
      Type = type;
      Balance = initialBalance;
    }

    public void ChangeName(string newName)
    {
      Name = newName;
    }

    public void ChangeType(AccountType newType)
    {
      Type = newType;
    }

    public void AddExpense(Expense newExpense)
    {
      Balance -= newExpense.Value;
      Expenses.Add(newExpense);
    }

    public void AddReceipt(Receipt newReceipt)
    {
      Balance += newReceipt.Value;
      Receipts.Add(newReceipt);
    }

    public void AddTransfer(Transfer newTransfer)
    {
      Transfers.Add(newTransfer);
    }

    public void Withdraw(decimal value)
    {
      if (value.IsNegative())
        throw new InvalidOperationException("Value should be positive");

      if (Balance < value)
        throw new InvalidOperationException("Not enough money to withdraw");

      Balance -= value;
    }

    public void Deposit(decimal value)
    {
      if (value.IsNegative())
        throw new InvalidOperationException("Value should be positive");

      Balance += value;
    }
  }
}