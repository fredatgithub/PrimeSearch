using System;

namespace PrimeSearch
{
  using System.Numerics;

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

      for (BigInteger i = number - 50 ; i < number; i++)
      {
        if (IsPrime(i))
        {
          Console.WriteLine(i + " est premier");
        }
        else
        {
          Console.WriteLine(i + " n'est pas premier");
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

      for (ulong i = 6; i < Math.Sqrt(number); i = i + 2)
      {
        if (number % i == 0)
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
      for (ulong i = 6; i < tmpSqr; i = i + 2)
      {
        if (number % i == 0)
        {
          return false;
        }
      }

      return true;
    }
  }
}