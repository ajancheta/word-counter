using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void UserWordTest_TestIfUserSentenceIsAString_True()
    {
      string testUserSentence = "test sentence";

      bool result = testUserSentence is string;

      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void UserWordTest_TestIfUserWordIsAString_True()
    {
      string testUserWord = "testWord";

      bool result = testUserWord is string;

      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void WordSearch_SearchWordAndReturnResult_Int()
    {

      string testUserWord = "dog";
      string testUserSentence = "Dog, dog, dog, walker walk$ Dog?!?";
      int testResult = 0;

      RepeatCounter newCounter = new RepeatCounter(testUserWord, testUserSentence, testResult);

      Assert.AreEqual(4, newCounter.WordSearch());
    }
  }
}
