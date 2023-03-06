using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabna_Conversion
{
  internal static class MabnaSixtean
  {
    public static List<string> Calculate(int number)
    {
      List<string> results = new();
      do
      {
        if (number % 16 >= 10)
        {
          if (number % 16 == 10)
          {
            results.Add("A");
          }

          if (number % 16 == 11)
          {
            results.Add("B");
          }

          if (number % 16 == 12)
          {
            results.Add("C");
          }

          if (number % 16 == 13)
          {
            results.Add("D");
          }

          if (number % 16 == 14)
          {
            results.Add("E");
          }

          if (number % 16 == 15)
          {
            results.Add("F");
          }
        }
        else
        {
          results.Add((number % 16).ToString());
        }
        number /= 16;
      } while (number >= 15);
      results.Add(number.ToString());
      return results;
    }
  }
}