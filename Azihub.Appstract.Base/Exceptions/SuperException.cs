using System;
using Azihub.Appstract.Base.Exceptions.Interface;

namespace Azihub.Appstract.Base.Exceptions
{
   public abstract class SuperException : Exception, IException
    {
        public string PublicMessage { get; protected set; }
        public string PrivateMessage { get; protected set; }
        public IErrorCode ErrorCode { get; }
        public TypeException TypeException { get; set; } = TypeException.Super;

        public abstract int Code { get; }
        public abstract string LocaleConst { get; }

        public SuperException(IErrorCode errorCode)
        {
            ErrorCode = errorCode;
        }

        public SuperException(string message) : base(message)
        {
        }

        public SuperException(string message, Exception exception) : base(message, exception)
        {
        }

    }
}
