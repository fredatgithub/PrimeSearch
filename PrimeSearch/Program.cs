using System;
using System.Numerics;
using PrimeToolsLibrary;

namespace PrimeSearch
{
  internal class Program
  {
    private static void Main()
    {
      ulong upperLimitNumber = 20;
      for (ulong i = 2; i < upperLimitNumber; i++)
      {
        if (PrimeTools.IsPrime(i))
        {
          Console.WriteLine($"{i} {PrimeTools.Negate("est", true)} premier");
        }
        else
        {
          Console.WriteLine($"{i} {PrimeTools.Negate("est", false)} premier");
        }
      }

      BigInteger number = new BigInteger(ulong.MaxValue);
      bool positiveness = false;
      for (BigInteger bigIntNumber = number - 1; bigIntNumber <= number; bigIntNumber++)
      {
        positiveness = PrimeTools.IsPrime(bigIntNumber);
        Console.WriteLine($"{bigIntNumber} {PrimeTools.Negate("est", positiveness)} premier");
      }

      Console.WriteLine("Press a key to exit");
      Console.ReadKey();
    }
  }
}