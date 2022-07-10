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
        

        //UC3 Program
        // Testing for throwing exception for null message 
        public void TestMethod1()
        {
            try
            {
                //Act
                string message = null;
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
        
        // Testing for throwing exception for null message 
        public void TestMethod1()
        {
            try
            {
                //Act
                string message = "";
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
        

        // UC4 problem
        //Testing for Reflection - MoodAnalyser Class Name Should Return MoodAnalyser Object
        public void TestMethod1()
        {
            string message = null;
            object expected = new MoodAnalyse(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyse", "MoodAnalyse");
            expected.Equals(obj);
        }
        */
        //UC4_TC4.2
        public void TestMethod1()
        {
            string expected = "Class Not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyse", "MoodAnalyse");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }


    }

}
