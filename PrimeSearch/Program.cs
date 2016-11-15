using System;

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
  }
}