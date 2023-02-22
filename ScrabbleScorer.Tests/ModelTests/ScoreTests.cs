using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System.Collections.Generic;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void ScoreConstructor_CreatesInstanceOfScore_Score()
    {
      Score newScore = new Score();
      Assert.AreEqual(typeof(Score), newScore.GetType());
    }
    [TestMethod]
    public void ScoreClass_CreateDictionaryToHoldCharacterScores_Dictionary()
    {
      Dictionary<char, int> letterPoints = new Dictionary<char, int>() {};
      Assert.AreEqual(typeof(Dictionary<char, int>), letterPoints.GetType());
    }
    [TestMethod]
    public void ScoreClass_AddCharactersWorthOnePointToDictionary_Dictionary()
    {
      Dictionary<char, int> letterPoints = new Dictionary<char, int>() {};
      letterPoints['A'] = 1;
      letterPoints['E'] = 1;
      letterPoints['I'] = 1;
      letterPoints['O'] = 1;
      letterPoints['U'] = 1;
      letterPoints['L'] = 1;
      letterPoints['N'] = 1;
      letterPoints['R'] = 1;
      letterPoints['S'] = 1;
      letterPoints['T'] = 1;
      CollectionAssert.AreEquivalent(new Dictionary<char, int>() { {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1} }, letterPoints);
    }
    [TestMethod]
    public void ScoreClass_AddCharactersWorthTwoPointsToDictionary_Dictionary()
    {
      Dictionary<char, int> letterPoints = new Dictionary<char, int>() { {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1} };
      letterPoints['D'] = 2;
      letterPoints['G'] = 2;
      CollectionAssert.AreEquivalent(new Dictionary<char, int>() { {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1}, {'D', 2}, {'G', 2} }, letterPoints);
    }
    [TestMethod]
    public void ScoreClass_AddCharactersWorthThreePointsToDictionary_Dictionary()
    {
      Dictionary<char, int> letterPoints = new Dictionary<char, int>() { {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1}, {'D', 2}, {'G', 2} };
      letterPoints['B'] = 3;
      letterPoints['C'] = 3;
      letterPoints['M'] = 3;
      letterPoints['P'] = 3;
      CollectionAssert.AreEquivalent(new Dictionary<char, int>() { {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1}, {'D', 2}, {'G', 2}, {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3} }, letterPoints);
    }
  }
}