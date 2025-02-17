﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram
{
    public class CustomException : Exception
    {
        public ExceptionType type;

        public enum ExceptionType
        {
            Null_Type_Exception,
            Empty_Type_Exception,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}