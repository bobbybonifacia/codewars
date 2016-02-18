using System;

//SequenceSum
public class SequenceSum
{
    public static int[] SumOfN(int n)
    {
        var num = Math.Abs(n) + 1;

        var array = new int[num];
        array[0] = 0;
        for (int i = 1; i < num; i++)
        {
            array[i] = Math.Sign(n) * i + array[i - 1];
        }

        return array;
    }
}