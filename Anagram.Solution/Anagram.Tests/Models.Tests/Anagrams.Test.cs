using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void FooInSmallDictionary()
    {
      var dictionary = new List<string>() {
        "foo", "bar", "baz", "potato", "tomato"
      };
      var anagrams = new Anagrams(dictionary, "oof");
      var results = anagrams.YesAnagrams();

      var expectedResults = new List<string>() { "foo" };
      CollectionAssert.AreEqual(expectedResults, results);
    }


  }
}
