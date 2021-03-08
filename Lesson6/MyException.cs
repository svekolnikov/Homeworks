using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    public enum ErrorCodes
    {
        MyArraySizeException,
        MyArrayDataException
    }

    public class MyException : Exception
    {
        public MyException(ErrorCodes code)
        {
            Code = code;
        }

        public ErrorCodes Code { get; }
    }
}
