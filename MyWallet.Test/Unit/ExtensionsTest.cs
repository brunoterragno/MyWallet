using System;
using System.Collections.Generic;
using MyWallet.Test.Models;
using Xunit;

namespace MyWallet.Test.Unit
{
  public class ExtensionsTest
  {
    [Fact]
    public void Create_A_Clone_Immutable_List()
    {
      // Arrange
      var originalList = new List<Account>();
      originalList.Add(new Account("Poupança", AccountType.Saving));
      originalList.Add(new Account("Corrente", AccountType.Checking));

      // Act
      var cloneList = originalList.Clone();

      // Assert
      Assert.NotSame(originalList, cloneList);
    }
  }
}