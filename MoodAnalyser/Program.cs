using System;

namespace MoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Problem");
            Console.WriteLine("\n");

            // string message = "I am in happy mood";
            // MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            // moodAnalyse.AnalyseMood();

            // string message = "";
            // MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            // moodAnalyse.AnalyseMood();


            // Reflection - MoodAnalyser Class Name Should Return MoodAnalyser Object
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();
            //Passing Wrong calss name to catch the exception
            MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyse", "MoodAnalyse");

        }
    }
}
