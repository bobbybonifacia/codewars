using System;

public class Numbers
{
  public static double TwoDecimalPlaces(double number)
  {
    var absnumber = Math.Abs(number);
    var multipliedBy1000 = (long)(absnumber*1000);
    var multipliedBy100 = (long)(absnumber*100);
    return (multipliedBy1000 % 10 >= 5 ? multipliedBy100 + 1 : multipliedBy100) / 100d * (number > 0 ? 1.0 : - 1.0);
  }
}
