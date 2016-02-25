using System;
using System.Text;

//link: http://www.codewars.com/kata/55466644b5d240d1d70000ba
public class Kata5
{
    public static int GetMissingCandies(int[] candies)
    {
        if (candies.Count() < 2) return -1;

        var sorted = candies.OrderByDescending(el => el).ToArray();

        int max_amount = sorted[0];
        int result = 0;
        for (int i = 1; i < sorted.Count(); i++)
            result += max_amount - sorted[i];

        return result;
    }
}