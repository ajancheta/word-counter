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

    // [TestMethod]
    // public void ViewEntries_HasCorrectModelType_ViewAll()
    // {
    //     GameController controller = new GameController();
    //     IActionResult viewEntries = controller.ViewInput();
    //     Assert.IsInstanceOfType(viewEntries, typeof(ViewResult));
    // }

    // [TestMethod]
    // public void DeleteEntries_HasCorrectModelType_DeleteAll()
    // {
    //     GameController controller = new GameController();
    //     IActionResult deleteEntries = controller.DeleteAll();
    //     Assert.IsInstanceOfType(deleteEntries, typeof(ViewResult));
    // }
  }
}
