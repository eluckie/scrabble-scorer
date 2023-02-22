using System;
using System.Collections.Generic;

namespace ScrabbleScorer.Models
{
  public class Score
  {
    public Dictionary<char, int> letterPoints = new Dictionary<char, int>()
    {
      {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1},
      {'D', 2}, {'G', 2},
      
    };
    public Score()
    {

    }
  }
}