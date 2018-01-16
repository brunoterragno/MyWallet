using System;
using Xunit;

namespace MyWallet.Test
{
    public class AccountTest
    {
        [Fact]
        public void Create_Account_Default_Values_Success()
        {
            // Arrange
            var account = new Account("Poupança", AccountType.Saving);

            // Act & Assert   
            Assert.Equal("Poupança", account.Name);
            Assert.Equal(AccountType.Saving, account.Type);
            Assert.Equal(0, account.Balance);
        }
    }
}