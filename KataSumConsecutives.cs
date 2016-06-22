using System.Collections.Generic;
using System.Linq;

public class Consecutives
{
  public static List<int> SumConsecutives(List<int> s) 
  {
    var resultList = new List<int>();
    var valueCount = 1;
    var previousValue = s.FirstOrDefault();
    foreach(var value in s.Skip(1))
    {
      if(value == previousValue)
      {
        valueCount++;
      }
      else
      {
        resultList.Add(previousValue * valueCount);
        valueCount = 1;
        previousValue = value;
      }
    }
    
    resultList.Add(previousValue * valueCount);
    
    return resultList;
  }
}
