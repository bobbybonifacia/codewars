using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    return arr.Sum(element => element > 0 ? element : 0);
  }
}
