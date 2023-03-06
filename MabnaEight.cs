using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabna_Conversion
{
  internal static class MabnaEight
  {
    public static List<string> Calculate(int number)
    {
      List<string> results = new();
      do
      {
        results.Add((number % 8).ToString());
        number /= 8;
      } while (number >= 7);
      results.Add(number.ToString());
      return results;
    }
  }
}