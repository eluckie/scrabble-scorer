using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;

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

  }
}