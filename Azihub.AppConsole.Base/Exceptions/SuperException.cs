using System;
using Azihub.AppConsole.Base.Exceptions.Interface;

namespace Azihub.AppConsole.Base.Exceptions
{
   public abstract class SuperException : Exception, IException
    {
        public string PublicMessage { get; protected set; }
        public string PrivateMessage { get; protected set; }
        public IErrorCode ErrorCode { get; }
        public TypeException TypeException { get; set; } = TypeException.Super;

        public abstract int Code { get; }
        public abstract string LocaleConst { get; }


        public string GetPublicMessage()
        {
            return $"[{(int)ErrorCode.Value}]: {PublicMessage}"; // Example : "[1234]: something went wrong"
        }

        public string GetPrivateMessage()
        {
            return $"[{(int)ErrorCode.Value}]: {PrivateMessage}";
        }

        public SuperException(IErrorCode errorCode) : base()
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
