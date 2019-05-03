using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Controllers
{
  public class GameController : Controller
  {

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


    [HttpPost("/game/new")]
    public ActionResult New()
    {
      return View();
    }

  }
}
