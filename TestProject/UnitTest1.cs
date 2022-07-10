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
         
        //UC4_TC4.3
        public void TestMethod1()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyse", "Demo");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
       
        //UC5 problem test
        public void TestMethod1()
        {
            object expected = new MoodAnalyse("I a in Happy mood");
            object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParametrisedConstructor("MoodAnalyse", "MoodAnalyse", "I a in Happy mood");
            expected.Equals(obj);
        }
         
        //UC5_TC_5.1 problem test
        public void TestMethod1()
        {
           
             object expected = new MoodAnalyse("I a in sad mood");

            object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParametrisedConstructor("MoodAnalyse", "MoodAnalyse", "I a in sad mood");

            expected.Equals(obj);
        }
       
        public void TestMethod1()
        {
            //5.2 problem
            string expected = "Class Not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParametrisedConstructor("MoodAnalyse", "MoodAnalyse", "Iam in sad Mood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
       
        public void TestMethod1()
        {
            //5.3 problem
            string expected = "Constructor is not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParametrisedConstructor("MoodAnalyse", "Demo", "Iam in sad Mood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
         
        public void TestMethod1()
        {
         
            // UC6 - reflection invoking the method AnalyseMood

            //Act
            string expected = "SAD";
            string message = "Iam in Sad Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            //Arrange
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
         */
        public void TestMethod1()
        {

            //TC 6.1 -  reflection invoking the method AnalyseMood by passing message Happy

            //Act
            string expected = "HAPPY";
            string message = "Happy";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            //Arrange
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }


    }

}
