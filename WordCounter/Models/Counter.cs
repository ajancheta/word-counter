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

    // public bool IsString(string sentenceInput, string wordInput)
    // {
    //   if (sentenceInput == "string" || wordInput == "string")
    //   {
    //     return true;
    //   }
    //   else
    //   {
    //     return false;
    //   }
    // }

  //     bool IsString(string sentenceInput, string wordInput)
  //     {
  //     foreach (string input in sentenceInput && string input in sentenceInput);
  //     {
  //         if (!string.IsString())
  //             return false;
  //     }
  //
  //     return true;
  // }

    public int WordSearch(string sentenceInput, string wordInput, int result)
    {
      string[] sentArray = sentenceInput.ToLower().Split(' ', '.', ',', '!', '?');

      for (int i = 0; i < sentArray.Length; i++)
      {
        if (wordInput.ToLower() == sentArray[i])
        {
          result ++;
        }
      }
      return result;
    }

    public static string GetSentence()
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
