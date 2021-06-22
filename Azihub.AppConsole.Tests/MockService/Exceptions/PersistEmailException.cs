using System;
using System.Collections.Generic;
using System.Text;
using Azihub.AppConsole.Base.Exceptions;

namespace Azihub.AppConsole.Tests.MockService.Exceptions
{
    public class PersistEmailException : ApplicationFailureException
    {
        [Obsolete("Never use this!")]
        public PersistEmailException() : base() { }
        public PersistEmailException(string emailAddress, Exception exception) : 
            base($"Failed to persist email address: {emailAddress}", exception)
        {

        }

        public override int Code => 201;

        public override string LocaleConst => "LOCALE_CONST";
    }
}
