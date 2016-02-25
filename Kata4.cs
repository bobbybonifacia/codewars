using System;
using System.Text;

//link: http://www.codewars.com/kata/formatting-decimal-places-number-1/csharp
public class Kata4
{
    public static double TwoDecimalPlaces(double number)
    {
        //Write your code here
        return (double)Math.Truncate(number * 100.0) / 100.0;
    }
}