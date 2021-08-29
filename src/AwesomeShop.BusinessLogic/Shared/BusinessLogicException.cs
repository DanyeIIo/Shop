﻿using System;

namespace AwesomeShop.BusinessLogic.Shared
{
    public enum ErrorType
    {
        NotFound,
        Invalid
    }
     
    public abstract class BusinessLogicException : ApplicationException
    {
        public abstract ErrorType Type { get; }
    }

    public class ResourceNotFoundException : BusinessLogicException
    {
        public override ErrorType Type => ErrorType.NotFound;
    }

    public class ValidationException : BusinessLogicException
    {
        public ValidationException(string message)
        {
            Message = message;
        }
        
        public string Message { get; }
        
        public override ErrorType Type => ErrorType.Invalid;

    }
}