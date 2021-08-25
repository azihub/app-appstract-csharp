using System;

namespace Azihub.Appstract.Base.Exceptions
{
    public abstract class SecurityException : Exception, IException
    {
        public SecurityException()
        {

        }
        public SecurityException(string message) : base(message)
        {

        }

        protected SecurityException(string message, Exception innerException) : base(message, innerException)
        {
        }
        public TypeException TypeException { get; set; } = TypeException.Security;
        public abstract int Code { get; }
        public abstract string LocaleConst { get; }
    }
}
