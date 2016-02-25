using System;
using System.Text;

//link: http://www.codewars.com/kata/54c27a33fb7da0db0100040e
public class Kata7
{
    public static bool IsSquare(int n)
    {
        return n < 0 ? false : n == Math.Pow((int)Math.Sqrt(n), 2);
    }
}