using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private static string _wordInput;
    private static string _sentenceInput;
    private static int _result;
    private static List<RepeatCounter> _userInputs = new List<RepeatCounter> {};
    private static int _id;

    public RepeatCounter(string wordInput, string sentenceInput, int result)
    {
      _sentenceInput = sentenceInput.ToLower();
      _wordInput = wordInput.ToLower();
      // _initialInput = (wordInput, sentenceInput);
      _result = 0;
      _userInputs.Add(this);
      _id = _userInputs.Count;
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

    public static string WordInput { get => _wordInput; set => _wordInput = value; }

    public static string SentenceInput { get => _sentenceInput; set => _sentenceInput = value; }

    public static int Result { get => _result; set => _result = value; }

    public static List<RepeatCounter> GetAll()
    {
      return _userInputs;
    }

    public int GetId()
    {
      return _id;
    }

    public static void ClearAll()
    {
      _userInputs.Clear();
    }
    //
    // public static RepeatCounter Find(int searchId)
    // {
    //   return _userInputs[searchId-1];
    // }
  }
}
