using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Anagram.Models
{
  public class Word
  {
    public string Base { get; set;}
    private List<string> _anagrams;

    public Word(List<string> baseWords, string word)
    {
      _anagrams = baseWords;
      Base = word;
    }
  }
}
