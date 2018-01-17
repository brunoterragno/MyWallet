using System;
using Xunit;

namespace MyWallet.Test
{
  public class TransferTest
  {
    [Fact]
    public void Create_Transfer_Between_Two_Accounts()
    {
      // Arrange
      var accountOne = new Account("Poupança", AccountType.Saving, 5000);
      var accountTwo = new Account("Corrent", AccountType.Checking, 1000);

      // Act
      var transfer = new Transfer(accountOne, accountTwo, 2000);

      // Assert
      Assert.Equal(2000, transfer.Value);
      Assert.Equal(3000, accountOne.Balance);
      Assert.Equal(3000, accountTwo.Balance);
      Assert.Equal(transfer, accountOne.GetTransfers[0]);
      Assert.Equal(transfer, accountTwo.GetTransfers[0]);
    }
  }
}