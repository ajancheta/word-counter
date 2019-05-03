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
      _sentenceInput = sentenceInput.ToLower();
      _wordInput = wordInput.ToLower();
      _result = 0;
    }

    public int WordSearch()
    {
      string[] sentArray = _sentenceInput.Split(' ', '.', ',', '!', '?', '&', '#', '(', ')', '$');
      string wordCounted = _wordInput;

      foreach (string word in sentArray)
      {
        if (word == wordCounted)
        {
          _result ++;
        }
      }
      return _result;
    }
    

    public static string SentenceInput { get => _sentenceInput; set => _sentenceInput = value; }

    public static string WordInput { get => _wordInput; set => _wordInput = value; }

    public static int Result { get => _result; set => _result = value; }
  }
}
