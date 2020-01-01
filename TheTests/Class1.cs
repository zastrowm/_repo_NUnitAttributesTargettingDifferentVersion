using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.AttributeVersions;
using NUnit.Framework;

namespace TheTests
{
    public class Class1
    {
      [Test, Custom]
      public void Test()
      {
        Console.WriteLine("Hello");
      }
    }

    [TestFixture(1, "ABC")]
    [TestFixture(4, "DEF")]
    public class ParametrizedTestFixtureTest
    {
      private readonly int _val;
      private readonly string _str;

      public ParametrizedTestFixtureTest(int val, string str)
      {
        _val = val;
        _str = str;
      }

      [Test, Custom]
      public void Test()
      {
        Console.WriteLine("Hello");
      }
    }
}
