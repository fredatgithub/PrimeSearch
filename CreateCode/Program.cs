using System;
using System.IO;

namespace CreateCode
{
  internal class Program
  {
    private static void Main()
    {
      const string primeTags = "<prime></prime>";
      const string primesClosingTag = "</primes>";
      const string primesOpenningTag = "<primes>";
      const string xmlStartTag = @"<?xml version=""1.0"" encoding=""utf-8"" ?>";
      const int numberOfTags = 78498;
      const string fileName = "primes3.xml";
      WriteXmlTag(xmlStartTag, primesOpenningTag, primeTags, primesClosingTag, numberOfTags, fileName);
      Console.WriteLine($"The file {fileName} has been created");
      Console.WriteLine("Press a key to exit:");
      Console.ReadKey();
    }

    private static void WriteXmlTag(string xmlStartTag, string primesOpenningTag, string primeTags, string primesClosingTag, int numberOfTags, string fileName)
    {
      StreamWriter sw = new StreamWriter(fileName);
      sw.WriteLine(xmlStartTag);
      sw.WriteLine(primesOpenningTag);
      for (int i = 0; i < numberOfTags; i++)
      {
        sw.WriteLine(primeTags);
      }
      sw.WriteLine(primesClosingTag);
      sw.Flush();
      sw.Close();
    }
  }
}