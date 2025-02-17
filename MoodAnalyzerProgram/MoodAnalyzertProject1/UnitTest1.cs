﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer1;
using MoodAnalyzerProgram;

namespace MoodAnalyzertProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NullMood()
        {
            string msg = " ";
            string expected = "HAPPY";

            MoodAnalyzer mood = new MoodAnalyzer(msg);

            string actual = mood.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getCustomNullException()
        {
            string expected = "message should not be null";
            MoodAnalyzer modeAnalyzer = new MoodAnalyzer(" ");

            try
            {
                string actual = modeAnalyzer.AnalyseMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void getCustomEmptyException()
        {
            string expected = "message should not be empty";
            MoodAnalyzer modeAnalyzer = new MoodAnalyzer(string.Empty);

            try
            {
                string actual = modeAnalyzer.AnalyseMood1();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]

        public void MoodAnalyseClassName()
        {
            try
            {
                string msg = null;

                object expected = new MoodAnalyzer(msg);
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser");
                expected.Equals(obj);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        [TestMethod]

        public void MoodAnalyseWrongClassName()
        {
            try
            {
                string msg = null;
                object expected = new MoodAnalyzer(msg);
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyserWrong", "MoodAnalyserWrong");
                expected.Equals(obj);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        [TestMethod]

        public void MoodAnalyseWrongConstructor()
        {
            try
            {
                string msg = null;
                object expected = new MoodAnalyzer(msg);
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyserWrong");
                expected.Equals(obj);
            }

            catch (CustomException ex)
            {
                Assert.AreEqual("Constructor not found", ex.Message);
            }
        }

        [TestMethod]

        public void ParameterisedConstructor_MoodAnalyseClassName()
        {
            object expected = new MoodAnalyzer("HAPPY");
            object obj = MoodAnalyserFactory.MoodAnalyserParameterisedConstructor("MSTestMoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        [TestMethod]

        public void ParameterisedConstructor_WrongClassName()
        {
            try
            {
                object expected = new MoodAnalyzer("HAPPY");
                object obj = MoodAnalyserFactory.MoodAnalyserParameterisedConstructor("MSTestMoodAnalyzerProblem.MoodAnalyserWrong", "MoodAnalyser");
                expected.Equals(obj);
            }

            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        [TestMethod]
        public void ParameterisedConstructor_WrongConstrcutorName()
        {
            try
            {
                object expected = new MoodAnalyzer("HAPPY");
                object obj = MoodAnalyserFactory.MoodAnalyserParameterisedConstructor("MSTestMoodAnalyzerProblem.MoodAnalyser", "MoodAnalyserWrong");
                expected.Equals(obj);
            }

            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }
    }
}