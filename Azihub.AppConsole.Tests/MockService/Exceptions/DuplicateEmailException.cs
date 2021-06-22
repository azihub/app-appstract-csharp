using System;
using System.Collections.Generic;
using System.Text;
using Azihub.AppConsole.Base.Exceptions;

namespace Azihub.AppConsole.Tests.MockService.Exceptions
{
    public class DuplicateEmailException : BusinessLogicException
    {
        [Obsolete("Never use this!")]
        public DuplicateEmailException() : base() { }
        public DuplicateEmailException(string emailAddress) : 
            base($"Duplicate email address: {emailAddress}")
        {

        }

        public override int Code => 101;

        public override string LocaleConst => "LOCALE_CONST";
    }
}
