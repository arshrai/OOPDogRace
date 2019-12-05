using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPDogRace;

namespace DogRace_UnitTest
{
    [TestClass]
    public class DogRace_UnitTest
    {
        Bet obj_Bet = new Bet();
        [TestMethod]
        public void FindMaxBetTest()
        {
            var act = obj_Bet.FindMaxBet(52);
            Assert.AreEqual(expected: 50, act);
        }

        [TestMethod]
        public void FindMaxBetTest2()
        {
            var act = obj_Bet.FindMaxBet(15);
            Assert.AreEqual(expected: 15, act);
        }
    }
}
