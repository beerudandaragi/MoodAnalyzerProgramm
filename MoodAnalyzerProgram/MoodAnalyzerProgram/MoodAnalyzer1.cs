﻿using MoodAnalyzerProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer1
{
    public class MoodAnalyzer
    {
        public string msg;
        public MoodAnalyzer(string msg)
        {
            this.msg = msg;
        }

        public MoodAnalyzer()
        {
            this.msg = null;
        }

        public string AnalyseMood()
        {
            try
            {
                if (msg.ToLower().Contains(""))
                    return "HAPPY";

                else
                    return "SAD";
            }
            catch (NullReferenceException ex)
            {
                throw new CustomException(CustomException.ExceptionType.Null_Type_Exception, "Message should not be null");
            }
        }

        public string AnalyseMood1()
        {
            try
            {
                if (msg.ToLower().Contains(string.Empty))
                {
                    return "happy";
                }
                else
                    return "sad";
            }
            catch (NullReferenceException ex)
            {
                throw new CustomException(CustomException.ExceptionType.Empty_Type_Exception, "Message should not be empty");
            }
        }
    }
}