using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserTest
{ 
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }  
        public string AnalyserMethod(string message)
        {
            if (message.Contains("SAD"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
