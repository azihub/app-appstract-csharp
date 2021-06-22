﻿using Azihub.AppConsole.Base.Exceptions;

namespace Azihub.AppConsole.Tests.MockService.Exceptions
{
    public class BannedEmailException : SecurityException
    {
        public BannedEmailException(string emailAddress) : 
            base($"Email address was banned: {emailAddress}")
        {

        }

        public override int Code => 301;

        public override string LocaleConst => "LOCALE_CONST";
    }
}
