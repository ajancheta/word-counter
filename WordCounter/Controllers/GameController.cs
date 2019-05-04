using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class GameController : Controller
  {
    [HttpGet("/game/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/game")]
    public ActionResult Play()
    {
      return View();
    }

    [HttpPost("/game")]
    public ActionResult Create(string wordInput, string sentenceInput)
    {
       int result = 0;
       RepeatCounter newGame = new RepeatCounter(wordInput, sentenceInput, result);
       newGame.WordSearch();
       return RedirectToAction("Index", newGame);
    }

    [HttpPost("/game/delete")]
    public ActionResult DeleteAll(string wordInput, string sentenceInput)
    {
      int result = 0;
      RepeatCounter newGame = new RepeatCounter(wordInput, sentenceInput, result);
      RepeatCounter.ClearAll();
      return RedirectToAction("Index", newGame);
    }
  }
}
