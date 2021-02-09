using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserTest
{ 
    
    public class MoodAnalyser
    {
        string message = null;
        public string AnalyserMethod(string message)
        {
            if (this.message.Contains("SAD"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
