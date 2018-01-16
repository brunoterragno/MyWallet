using System;
using Xunit;

namespace MyWallet.Test
{
    public class AccountTest
    {
        [Fact]
        public void Create_Account_With_Default_Values()
        {
            // Arrange
            var account = new Account("Poupança", AccountType.Saving);

            // Act & Assert   
            Assert.Equal("Poupança", account.Name);
            Assert.Equal(AccountType.Saving, account.Type);
            Assert.Equal(0, account.Balance);
        }

        [Fact]
        public void Add_Expense_In_Account()
        {
            // Arrange
            var account = new Account("Poupança", AccountType.Saving);
            var newExpense = new Expense("Camiseta", ExpenseType.Purchase, 100.0M);

            // Act 
            account.AddExpense(newExpense);

            // Assert   
            Assert.Equal(1, account.GetExpenses.Count);
        }

        [Fact]
        public void Cannot_Add_Expense_In_Account_By_Expenses_List()
        {
            // Arrange
            var account = new Account("Poupança", AccountType.Saving);
            var newExpense = new Expense("Camiseta", ExpenseType.Purchase, 100.0M);

            // Act 
            account.GetExpenses.Add(newExpense);

            // Assert   
            Assert.Equal(0, account.GetExpenses.Count);
        }

        [Fact]
        public void Add_Receipt_In_Account()
        {
            // Arrange
            var account = new Account("Poupança", AccountType.Saving);
            var newReceipt = new Receipt(ReceiptType.Salary, 4000.0M);

            // Act 
            account.AddReceipt(newReceipt);

            // Assert   
            Assert.Equal(1, account.GetReceipts.Count);
        }

        [Fact]
        public void Cannot_Add_Receipt_In_Account_By_Receipts_List()
        {
            // Arrange
            var account = new Account("Poupança", AccountType.Saving);
            var newReceipt = new Receipt(ReceiptType.Salary, 4000.0M);

            // Act 
            account.GetReceipts.Add(newReceipt);

            // Assert   
            Assert.Equal(0, account.GetReceipts.Count);
        }
    }
}