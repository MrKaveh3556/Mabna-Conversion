using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabna_Conversion
{
  internal static class MabnaTwo
  {
    public static List<string> Calculate(int number)
    {
      List<string> results = new();
      do
      {
        results.Add((number % 2).ToString());
        number /= 2;
      } while (number >= 1);
      results.Add(number.ToString());
      return results;
    }
  }
}