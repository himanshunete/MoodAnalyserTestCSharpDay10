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
            moodAnalyser = new MoodAnalyser();
        }

        /// <summary>
        /// Given,When,Outcome
        /// </summary>
        [Test]
        public void Given_SadMood_Expecting_Sad_Result()
        {
            string expected = "SAD";

            string actual = moodAnalyser.AnalyserMethod("SAD");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Given,When,Outcome
        /// </summary>
        [Test]
        public void Given_AnyMood_Expecting_Happy_Result()
        {
            string expected = "HAPPY";

            string actual = moodAnalyser.AnalyserMethod("ANXIETY");
            Assert.AreEqual(expected, actual);
        }
    }
}