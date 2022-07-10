using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace TestProject
{
    [TestClass]
    public class Test1
    {
        [TestMethod]

        /*
        
        // UC1 Program
        
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
        

        // Added UC2 problem
        public void TestMethod1()
        {
            //Act

            string expected = "HAPPY";
            string message = null;
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            //Arrange
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        */
        // Testing for throwing exception for Empty message 
        public void TestMethod1()
        {
            try
            {
                //Act
                string message = " ";
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);

                //Arrange
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyserCustomException ex)
            {
                string expected = "Mood Should not be Empty";
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }

        }


    }

}
