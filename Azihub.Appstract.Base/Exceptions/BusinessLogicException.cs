using System;

namespace Azihub.Appstract.Base.Exceptions
{
    public abstract class BusinessLogicException : Exception, IException
    {
        public BusinessLogicException()
        {

        }

        public BusinessLogicException(string message) : base(message)
        {

        }

        /// <summary>
        /// User must implement Unique Code number (temporary set as int type).
        /// </summary>
        public abstract int Code { get; }
        public abstract string LocaleConst { get;  }
        public BusinessLogicException[] Errors { get; set; }
        public TypeException TypeException { get; set; } = TypeException.BusinessLogic;
    }
}
