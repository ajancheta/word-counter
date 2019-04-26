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
    public void UserWordTest_TestIfUserSentenceIsAString_String()
    {
      //Arrange
      string testUserSentence = "test sentence";

      //Act
      bool result = testUserSentence is string;

      //Assert
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void UserWordTest_TestIfUserWordIsAString_String()
    {
      //Arrange
      string testUserWord = "testWord";

      //Act
      bool result = testUserWord is string;

      //Assert
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void WordSearch_SearchWordAndReturnResult_Int()
    {

      string testUserSentence = "Dog, walker walks dog?!?";
      string testUserWord = "dog";
      int testResult = 0;

      RepeatCounter newCounter = new RepeatCounter(testUserSentence, testUserWord, testResult);

      Assert.AreEqual(2, newCounter.WordSearch(testUserSentence, testUserWord, testResult));
    }
  }
}
