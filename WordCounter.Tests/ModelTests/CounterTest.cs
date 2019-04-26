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
    public void UserWordTest_TestIfUserWordStoresAsAString_String()
    {
      //Arrange
      string testUserWord = "testWord";

      //Act
      bool result = testUserWord is string;

      //Assert
      Assert.AreEqual(true, result);
    }
  }
}
