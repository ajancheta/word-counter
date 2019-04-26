using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private static string _sentenceInput;
    private static string _wordInput;
    private static int _result;

  public RepeatCounter(string sentenceInput, string wordInput, int result)
  {
    _sentenceInput = sentenceInput;
    _wordInput = wordInput;
    _result = result;
  }

  }
}
