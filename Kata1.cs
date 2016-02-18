using System;

//Find the next perfect square!
public class Kata
{
    public static long FindNextSquare(long num)
    {
        //check if num is square
        var sqrtnum = (long)Math.Sqrt(num);

        if (num != sqrtnum * sqrtnum)
            return -1;
        //take the next number and return square  
        return (sqrtnum + 1) * (sqrtnum + 1);
    }
}