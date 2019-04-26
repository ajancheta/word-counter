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
      _sentenceInput = sentenceInput;
      _wordInput = wordInput;
      _result = result;
    }

    public int WordSearch(string sentenceInput, string wordInput, int result)
    {
      string[] sentArray = sentenceInput.ToLower().Split(' ', '.', ',', '!', '?', '&', '#', '(', ')', '$');

      for (int i = 0; i < sentArray.Length; i++)
      {
        if (wordInput.ToLower() == sentArray[i])
        {
          result ++;
        }
      }
      return result;
    }

    public bool RuleOutSymbols(string wordInput)
    {
      if (wordInput != str)
      {
        return true;
      }

      else
      {
      return false;
      }
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
