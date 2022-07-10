﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        public string message;

        //constructor 
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        //Creating method for Analyzing mood
        /*
         public string AnalyseMood()
         {
             try
             {
                 if (this.message.Contains("sad"))
                 {
                     Console.WriteLine("SAD");
                     return "SAD";
                 }
                 else
                 {
                     Console.WriteLine("HAPPY");
                     return "HAPPY";
                 }
             }
             catch
             {
                 Console.WriteLine("HAPPY");
                 return "HAPPY";
             }
         }
        */
        //Creating method for handling  exception
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood Should not be Empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood Should Not be Null");

            }
        }

    }
}
