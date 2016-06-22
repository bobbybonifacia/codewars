using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public string Generate(int length)
    {
        var resultString = string.Empty;
        var random = new Random();
        for (int i= 0; i < length; i++)
        {
           var generatedInt =  random.Next(0, 2);
           resultString += generatedInt.ToString();
        }
        
        return resultString;
    }
}
