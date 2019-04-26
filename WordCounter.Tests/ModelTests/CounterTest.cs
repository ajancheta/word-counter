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
      //Arrange
      int testResult = 0;
      string testUserSentence = "Dog walker walks dog";
      string testUserWord = "dog";

      //Act
      RepeatCounter newCounter = new RepeatCounter(testUserSentence, testUserWord, testResult);

      //Assert
      Assert.AreEqual(2, newCounter.WordSearch(testUserSentence, testUserWord, testResult));
    }

    [TestMethod]
    public void GetSentence_StoreUserSentenceInput_True()
    {
      //Arrange
      string testUserSentence = "Dog walker walks dog";

      //Act
      RepeatCounter newSentInput = new RepeatCounter(testUserSentence);

      //Assert
      Assert.AreEqual("Dog walker walks dog", newSentInput.GetSentInput(testUserSentence));
    }
  }
}
