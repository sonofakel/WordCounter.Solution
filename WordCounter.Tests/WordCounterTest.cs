using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCountTests
  {
    [TestMethod]
    public void CountRepeats_SentenceDoesntContainWord_0()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("cats", "I love dogs");
      int expected = 0;
      int actual = testRepeatCounter.CountRepeats();
      Assert.AreEqual(expected, actual);

    }
    [TestMethod]
    public void CountRepeats_SentenceContainOneWord_1()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("lamp", "I love lamp");
      int expected = 1;
      int actual = testRepeatCounter.CountRepeats();
      Assert.AreEqual(expected, actual);

    }
    // public void Dispose()
    //  {
    //      RepeatCounter.ClearAll();
    //  }
  }
}
