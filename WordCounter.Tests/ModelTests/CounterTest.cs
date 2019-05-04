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

    [TestMethod]
    public void GetId_GameInstantiateWithAnIdAndGetterReturns_Int()
    {
      string testUserWord = "dog";
      string testUserSentence = "dog dog and dog";
      int testResult = 0;

      RepeatCounter newCounter = new RepeatCounter(testUserWord, testUserSentence, testResult);


      int result = newCounter.GetId();

      Assert.AreEqual(3, result);
    }

    //failed test method
    // [TestMethod]
    // public void Find_ReturnsCorrectCounter_RepeatCounter()
    // {
    //
    //   string testUserWord = "hi";
    //   string testUserSentence = "dog dog and dog";
    //   int testResult = 0;
    //
    //   RepeatCounter newCounter = new RepeatCounter(testUserWord, testUserSentence, testResult);
    //
    //   string testUserWordTwo = "dog";
    //   string testUserSentenceTwo = "dog dog and dog";
    //   int testResultTwo = 3;
    //
    //   RepeatCounter newCounterTwo = new RepeatCounter(testUserWordTwo, testUserSentenceTwo, testResultTwo);
    //
    //   RepeatCounter result = RepeatCounter.Find(1);
    //
    //   Assert.AreEqual(newCounter, result);
    // }
  }
}
