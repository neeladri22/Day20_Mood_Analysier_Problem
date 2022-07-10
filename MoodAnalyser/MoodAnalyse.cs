using System;
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
        public string AnalyseMood()
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
    }
}
