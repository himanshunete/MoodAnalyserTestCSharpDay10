using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserTest
{ 
    
    public class MoodAnalyser
    {
        string message;
        /// <summary>
        /// setting parameterised constructor with sad or happy message
        /// </summary>
        /// <param name="message"></param>

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyserMethod()
        {
            if (this.message.Contains("SAD"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
