using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _wordToCount;
    private string _inputString;
    private static int _wordCount;

    public RepeatCounter (string wordToCount, string inputString)
    {
     _wordToCount = wordToCount;
     _inputString = inputString;
     _wordCount = 0;
    }

    public int CountRepeats()
    {
      if (_inputString.Contains(_wordToCount))
      {
      _wordCount ++;

      }
      return _wordCount;
    }
    // public static void ClearAll()
    // {
    //   _wordCount = 0;
    // }
  }
}

// _inputString.Split().ToString().Contains(_wordToCount)
