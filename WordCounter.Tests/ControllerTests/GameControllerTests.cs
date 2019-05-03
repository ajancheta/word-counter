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


    // [TestMethod]
    // public void NewView_HasCorrectModelType_New()
    // {
    //   ViewResult newView = new GameController().New() as ViewResult;
    //
    //   var newGame = newView.ViewData.Model;
    //
    //   Assert.IsInstanceOfType(newGame, typeof(ViewResult));
    // }

    // [TestMethod]
    // public void PlayView_HasCorrectModelType_Play()
    // {
    //     ActionResult playView = new GameController().Play() as ActionResult;
    //
    //     var newPlay = playView.ViewData.Model;
    //
    //     Assert.IsInstanceOfType(newPlay, typeof(ActionResult));
    //
    // }


    [TestMethod]
    public void CreateView_HasCorrectModelType_Create()
    {
        GameController controller = new GameController();
        IActionResult createView = controller.Create("word", "word in word");
        Assert.IsInstanceOfType(createView, typeof(RedirectToActionResult));
    }
  }
}
