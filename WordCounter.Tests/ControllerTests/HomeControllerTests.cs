using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index()
    {
      HomeController homeController = new HomeController();
      ActionResult indexView = homeController.Index();
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
  }
}
