using System;
using System.Linq;

public class Scramblies 
{
    public static bool Scramble(string str1, string str2) 
    {
        var listOfChars = str1.ToList();
        foreach (var item in str2)
        {
          if(listOfChars.Contains(item))
          {
            listOfChars.RemoveAt(listOfChars.IndexOf(item));
          }
          else return false;
        }
        
        return true;
    }
}
