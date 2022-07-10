using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace TestProject
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Act

            string expected = "HAPPY";
            string message = "I am in happy mood";

            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            //Arrange
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
