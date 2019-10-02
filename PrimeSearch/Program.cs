using System;
using System.Numerics;
namespace PrimeSearch
{
  internal class Program
  {
    private static void Main()
    {
      ulong upperLimitNumber = 20;
      for (ulong i = 2; i < upperLimitNumber; i++)
      {
        if (IsPrime(i))
        {
          Console.WriteLine($"{i} {Negate("est", true)} premier");
        }
        else
        {
          Console.WriteLine($"{i} {Negate("est", false)} premier");
        }
      }

      BigInteger number = new BigInteger(ulong.MaxValue);
      bool positiveness = false;
      for (BigInteger bigIntNumber = number - 1; bigIntNumber <= number; bigIntNumber++)
      {
        positiveness = IsPrime(bigIntNumber);
        Console.WriteLine($"{bigIntNumber} {Negate("est", positiveness)} premier");
      }

      Console.WriteLine("Press a key to exit");
      Console.ReadKey();
    }

    private static string Negate(string verb, bool positive)
    {
      if (positive)
      {
        return verb;
      }
      else
      {
        return $"n'{verb} pas";
      }
    }

    private static bool IsPrime(ulong number)
    {
      if (number <= 1)
      {
        return false;
      }

      if (number == 2 || number == 3 || number == 5)
      {
        return true;
      }

      if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0)
      {
        return false;
      }

      for (ulong divisor = 7; divisor < Math.Sqrt(number); divisor = divisor + 2)
      {
        if (number % divisor == 0)
        {
          return false;
        }
      }

      return true;
    }

    private static bool IsPrime(BigInteger number)
    {
      if (number.IsEven)
      {
        return false;
      }

      if (number.Sign == 0 || number.Sign == -1)
      {
        return false;
      }

      if (number == 2 || number == 3 || number == 5)
      {
        return true;
      }

      if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0)
      {
        return false;
      }

      var tmpSqr = Math.Exp(BigInteger.Log(number) / 2);
      for (ulong divisor = 7; divisor < tmpSqr; divisor = divisor + 2)
      {
        if (number % divisor == 0)
        {
          return false;
        }
      }

      return true;
    }
  }
}