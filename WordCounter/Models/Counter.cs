using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _wordInput;
    private string _sentenceInput;
    private int _result;
    private static List<RepeatCounter> _userInputs = new List<RepeatCounter> {};
    private int _id;
    private string _initialWord;
    private string _initialSent;

    public RepeatCounter(string wordInput, string sentenceInput)
    {
      _sentenceInput = sentenceInput.ToLower();
      _wordInput = wordInput.ToLower();
      _userInputs.Add(this);
      _id = _userInputs.Count;
      _initialWord = wordInput;
      _initialSent = sentenceInput;
    }

    public int WordSearch()
    {
      int result = 0;
      string[] sentArray = _sentenceInput.Split(' ', '.', ',', '!', '?', '&', '#', '(', ')', '$');
      string wordCounted = _wordInput;

      foreach(string word in sentArray)
      {
        if (word == wordCounted)
        {
          _result ++;
        }
      }
      return _result;
    }

    public string WordInput { get => _wordInput; set => _wordInput = value; }

    public string SentenceInput { get => _sentenceInput; set => _sentenceInput = value; }

    public string WordEntry { get => _initialWord; set => _initialWord = value; }

    public string SentEntry { get => _initialSent; set => _initialSent = value; }

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

    public static RepeatCounter Find(int searchId)
    {
      return _userInputs[searchId-1];
    }
  }
}
