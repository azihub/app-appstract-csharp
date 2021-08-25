using System;
using Azihub.Appstract.Base.Exceptions;

namespace Azihub.Appstract.Tests.MockService.Exceptions
{
    public class PersistEmailException : ApplicationFailureException
    {
        public PersistEmailException(string emailAddress, Exception exception) : 
            base($"Failed to persist email address: {emailAddress}", exception)
        {

        }

        public override int Code => 201;

        public override string LocaleConst => "LOCALE_CONST";
    }
}
