using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Anagram.Models
{
  public class Anagrams
  {
    public string Word { get; set; }
    public List<string> BaseWords { get; set; }

    public Anagrams(List<string> baseWords, string word)
    {
      BaseWords = baseWords;
      Word = word;
    }

    public List<string> YesAnagrams()
    {
      var resultBaseWords = new List<string>();
      var wordArray = Word.ToLower().ToCharArray();
      Array.Sort(wordArray);
      var wordString = string.Join("", wordArray);

      foreach (var baseWord in BaseWords)
      {
        if (wordArray.Length != baseWord.Length)
        {
          continue;
        }
//continue: will ignore basewords that are not equal length and go back to beggining of foreach
        var baseWordArray = baseWord.ToLower().ToCharArray();
        Array.Sort(baseWordArray);
        var baseWordString = string.Join("", baseWordArray);
        if (wordString == baseWordString)
        {
          resultBaseWords.Add(baseWord);
        }
      }
      return resultBaseWords;
    }
  }
}
