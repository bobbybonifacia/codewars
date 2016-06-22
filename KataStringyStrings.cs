using System.Linq;

public class Kata
{
  public static string Stringy(int size)
  {
    return string.Join(string.Empty, Enumerable.Range(0, size).Select(element => element % 2 == 0 ? '1' : '0'));
  }
}
