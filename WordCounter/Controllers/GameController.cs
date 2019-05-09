using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class GameController : Controller
  {

    [HttpGet("/game")]
    public ActionResult Index()
    {
      List<RepeatCounter> allGames = RepeatCounter.GetAll();
      return View(allGames);
    }

    [HttpGet("/game/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/game/show")]
    public ActionResult Create(string wordInput, string sentenceInput)
    {
       RepeatCounter newGame = new RepeatCounter(wordInput, sentenceInput);
       return RedirectToAction("Index");
    }

    [HttpPost("/game/delete")]
    public ActionResult DeleteAll()
    {

      RepeatCounter.ClearAll();
      return RedirectToAction("Index");
    }
  }
}
