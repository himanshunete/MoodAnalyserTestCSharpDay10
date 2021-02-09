using NUnit.Framework;
using MoodAnalyserTest;

namespace NUnitTestProject1
{
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        [SetUp]
        public void Setup()
        {
            moodAnalyser = new MoodAnalyser("SAD");
        }

        /// <summary>
        /// Given,When,Outcome
        /// </summary>
        [Test]
        public void Given_SadMood_Expecting_Sad_Result()
        {
            string expected = "SAD";

            string actual = moodAnalyser.AnalyserMethod();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Given,When,Outcome
        /// </summary>
        [Test]
        public void Given_AnyMood_Expecting_Happy_Result()
        {
            moodAnalyser = new MoodAnalyser("ANXIETY");
            string expected = "HAPPY";

            string actual = moodAnalyser.AnalyserMethod();
            Assert.AreEqual(expected, actual);
        }
    }
}