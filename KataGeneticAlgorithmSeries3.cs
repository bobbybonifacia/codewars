using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public IEnumerable<string> Crossover(string chromosome1, string chromosome2, int cut)
    {
      return new string[] { 
        string.Concat(chromosome1.Substring(0, cut), chromosome2.Substring(cut)),
        string.Concat(chromosome2.Substring(0, cut), chromosome1.Substring(cut))};
    }
}
