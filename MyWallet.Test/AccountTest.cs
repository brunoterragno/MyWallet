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
            var newExpense = new Expense("Camiseta", ExpenseType.Purchase, 100);

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
            var newExpense = new Expense("Camiseta", ExpenseType.Purchase, 100);

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
            var newReceipt = new Receipt(ReceiptType.Salary, 4000);

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
            var newReceipt = new Receipt(ReceiptType.Salary, 4000);

            // Act 
            account.GetReceipts.Add(newReceipt);

            // Assert   
            Assert.Equal(0, account.GetReceipts.Count);
        }

        [Fact]
        public void Add_Receipt_Increase_Account_Balance()
        {
            // Arrange
            var account = new Account("Poupança", AccountType.Saving, 1000);
            var newReceipt = new Receipt(ReceiptType.Salary, 4000);

            // Act 
            account.AddReceipt(newReceipt);

            // Assert   
            Assert.Equal(5000, account.Balance);
        }

        [Fact]
        public void Add_Expense_Decrease_Account_Balance()
        {
            // Arrange
            var account = new Account("Poupança", AccountType.Saving, 1000);
            var newExpense = new Expense("Camiseta", ExpenseType.Purchase, 150);

            // Act 
            account.AddExpense(newExpense);

            // Assert   
            Assert.Equal(850, account.Balance);
        }

        [Fact]
        public void Withdraw_Value_From_Balance()
        {
            // Arrange
            var accountOne = new Account("Poupança", AccountType.Saving, 5000);

            // Act
            accountOne.Withdraw(2000);

            // Assert
            Assert.Equal(3000, accountOne.Balance);
        }

        [Fact]
        public void Deposit_Value_In_Balance()
        {
            // Arrange
            var accountTwo = new Account("Corrent", AccountType.Checking, 1000);

            // Act
            accountTwo.Deposit(2000);

            // Assert
            Assert.Equal(3000, accountTwo.Balance);
        }

        [Fact]
        public void Cannot_Withdraw_Bigger_Value_Than_Value_In_Balance()
        {
            // Arrange
            var accountOne = new Account("Poupança", AccountType.Saving, 5000);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => accountOne.Withdraw(6000));
        }
    }
}