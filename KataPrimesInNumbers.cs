using System;

public class PrimeDecomp {

  public static String factors(int lst) {
    var resultString = string.Empty;
    var currentPrimeNumber = 2;
    var deviderCount = 0;
    
    while(lst != 1)
    {
      if(lst % currentPrimeNumber == 0)
      {
        lst = (int)(lst / currentPrimeNumber);
        deviderCount++;
      }
      else
      {
        if(deviderCount > 0)
        {
          if(deviderCount > 1)
          {
            resultString += string.Format("({0}**{1})", currentPrimeNumber, deviderCount);
          }
          else
          {
            resultString += string.Format("({0})", currentPrimeNumber);
          }
          
          deviderCount = 0;
        }
        
        currentPrimeNumber++;
      }
    }
    
    
    if(deviderCount > 0)
    {
      if(deviderCount > 1)
      {
        resultString += string.Format("({0}**{1})", currentPrimeNumber, deviderCount);
      }
      else
      {
        resultString += string.Format("({0})", currentPrimeNumber);
      }
    }
    
    return resultString;
  }
}
