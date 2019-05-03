using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class GameControllerTest
  {

    [TestMethod]
    public void NewView_HasCorrectModelType_New()
    {
      GameController controller = new GameController();

      ActionResult newView = controller.New();

      Assert.IsInstanceOfType(newView, typeof(ViewResult));
    }

    [TestMethod]
    public void PlayView_HasCorrectModelType_Play()
    {
        GameController controller = new GameController();
        ActionResult playView = controller.Play();
        Assert.IsInstanceOfType(playView, typeof(ViewResult));
    }

    [TestMethod]
    public void CreateView_HasCorrectModelType_Create()
    {
        GameController controller = new GameController();
        IActionResult createView = controller.Create("word", "word in word");
        Assert.IsInstanceOfType(createView, typeof(RedirectToActionResult));
    }
  }
}
