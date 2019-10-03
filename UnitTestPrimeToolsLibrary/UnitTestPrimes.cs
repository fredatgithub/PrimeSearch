using PrimeToolsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPrimeToolsLibrary
{
  [TestClass]
  public class UnitTestPrimes
  {
    [TestMethod]
    public void TestMethod_IsPrime_0()
    {
      const int source = 0;
      const bool expected = false;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_1()
    {
      const int source = 1;
      const bool expected = false;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_2()
    {
      const int source = 2;
      const bool expected = true;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_3()
    {
      const int source = 3;
      const bool expected = true;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_4()
    {
      const int source = 4;
      const bool expected = false;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_5()
    {
      const int source = 5;
      const bool expected = true;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_6()
    {
      const int source = 6;
      const bool expected = false;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_7()
    {
      const int source = 7;
      const bool expected = true;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_8()
    {
      const int source = 8;
      const bool expected = false;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_9()
    {
      const int source = 9;
      const bool expected = false;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_10()
    {
      const int source = 10;
      const bool expected = false;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_11()
    {
      const int source = 11;
      const bool expected = true;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_12()
    {
      const int source = 12;
      const bool expected = false;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_13()
    {
      const int source = 13;
      const bool expected = true;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_14()
    {
      const int source = 14;
      const bool expected = false;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_15()
    {
      const int source = 15;
      const bool expected = false;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_16()
    {
      const int source = 16;
      const bool expected = false;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_17()
    {
      const int source = 17;
      const bool expected = true;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_18()
    {
      const int source = 18;
      const bool expected = false;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_19()
    {
      const int source = 19;
      const bool expected = true;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsPrime_20()
    {
      const int source = 20;
      const bool expected = false;
      bool result = PrimeTools.IsPrime(source);
      Assert.AreEqual(result, expected);
    }
  }
}
