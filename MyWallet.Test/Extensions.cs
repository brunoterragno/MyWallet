using System;
using System.Collections.Generic;

namespace MyWallet.Test
{
  public static class Extensions
  {
    public static List<T> Clone<T>(this List<T> list) where T : class
    {
      var newList = new List<T>();
      newList.AddRange(list);

      return newList;
    }
  }
}