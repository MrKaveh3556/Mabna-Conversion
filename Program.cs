using System.Text;

namespace Mabna_Conversion
{
  internal static class Program
  {
    private static void printdash() => Console.WriteLine("\n==============\n");

    private static void Main(string[] args)
    {
      string permission;
      do
      {
        int mabna = ReadMabna();
        printdash();

        int number = ReadNumber();
        printdash();

        if (mabna == 2)
        {
          PrintResult(MabnaTwo.Calculate(number));
        }
        else if (mabna == 8)
        {
          PrintResult(MabnaEight.Calculate(number));
        }
        else
        {
          PrintResult(MabnaSixtean.Calculate(number));
        }
        printdash();

        permission = Permission();
      } while (permission == "yes");

      printdash();
      Console.WriteLine("thanks for using this program :)");
    }

    #region read mabna

    public static int ReadMabna()
    {
      int result = 0;
      do
      {
        Console.Write("Enter Mabna [2] [8] [16]: ");
        string mabna = Console.ReadLine();
        result = Return(mabna);
        if (result == 2 || result == 8 || result == 16)
        {
          break;
        }
        else
        {
          Console.Write("\nYou Entered Wrong Mabna :(\n");
          printdash();
        }
      } while (result != 2 || result != 8 || result != 16);
      return result;
    }

    public static int Return(string number, int result = 0)
    {
      int.TryParse(number, out result);
      return result;
    }

    public static int ReadNumber()
    {
      int result = 0;
      do
      {
        Console.Write("Enter Number : ");
        string number = Console.ReadLine();
        result = Return(number);
        if (result > 0 || result <= int.MaxValue)
        {
          break;
        }
        else
        {
          Console.Write("\nYou Entered Invalid Number :(\n");
          printdash();
        }
      } while (result < 0 || result > int.MaxValue);
      return Convert.ToInt32(result);
    }

    #endregion read mabna

    #region print result

    private static void PrintResult(List<string> result)
    {
      string number = "";
      foreach (string item in result)
      {
        number += item;
      }
      Console.WriteLine($"your output : {number}");
    }

    #endregion print result

    #region permission to continue

    private static string Permission()
    {
      string result;
      do
      {
        Console.Write("do you want to continue?! [no] [yes] : \n");
        string temp = Console.ReadLine();
        result = temp == string.Empty ? "empty" : temp.ToLower();
        if (result == "yes")
        {
          break;
        }
      } while (result != "no");
      return result;
    }

    #endregion permission to continue
  }
}