using System;
using System.Linq;

//Return the Missing Element
public static class Kata
{
    public static int GetMissingElement(int[] superImportantArray)
    {
        return 45 - superImportantArray.Sum();
    }
}