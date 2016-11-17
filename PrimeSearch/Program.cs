using System;
using System.Numerics;
namespace PrimeSearch
{
  internal class Program
  {
    private static void Main()
    {
      for (ulong i = 2; i < 50001; i++)
      {
        if (IsPrime(i))
        {
          Console.WriteLine(i);
        }
      }

      BigInteger number = new BigInteger(ulong.MaxValue);
      if (IsPrime(number))
      {
        Console.WriteLine(number + " est premier");
      }
      else
      {
        Console.WriteLine(number + " n'est pas premier");
      }

      for (BigInteger bigIntNumber = number - 50 ; bigIntNumber < number; bigIntNumber++)
      {
        if (IsPrime(bigIntNumber))
        {
          Console.WriteLine(bigIntNumber + " est premier");
        }
        else
        {
          Console.WriteLine(bigIntNumber + " n'est pas premier");
        }
      }

      Console.WriteLine("Press a key to exit");
      Console.ReadKey();
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

      for (ulong tmpDivisor = 6; tmpDivisor < Math.Sqrt(number); tmpDivisor = tmpDivisor + 2)
      {
        if (number % tmpDivisor == 0)
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
      for (ulong divisor = 6; divisor < tmpSqr; divisor = divisor + 2)
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