using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _sentenceInput;
    private string _wordInput;
    private int _result;

    public RepeatCounter(string sentenceInput, string wordInput, int result)
    {
      _sentenceInput = sentenceInput.ToLower();
      _wordInput = wordInput.ToLower();
      _result = 0;
    }

    public int WordSearch()
    {
      string[] sentArray = _sentenceInput.Split(' ', '.', ',', '!', '?', '&', '#', '(', ')', '$');

      for (int i = 0; i < sentArray.Length; i++)
      {
        if (wordInput.ToLower() == sentArray[i])
        {
          result ++;
        }
      }
      return result;
    }

    public string GetSentence()
    {

      return _sentenceInput;
    }

    public string GetWord()
    {

      return _wordInput;
    }

    public int GetResult()
    {
      return _result;
    }
  }
}
