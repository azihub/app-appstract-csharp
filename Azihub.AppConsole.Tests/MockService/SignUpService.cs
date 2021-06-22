using Azihub.AppConsole.Tests.MockService.Exceptions;
using System;

namespace Azihub.AppConsole.Tests.MockService
{
    public class SignUpService
    {
        /// <summary>
        /// Business Logic Exception
        /// </summary>
        public const string DUPLICATE_EMAIL = "duplicate@email.com";

        /// <summary>
        /// Application Failure Exception
        /// </summary>
        public const string PERSIST_EMAIL_FAILED = "persist_failed@email.com";

        /// <summary>
        /// Security Exception
        /// </summary>
        public const string BANNED_EMAIL_FAILED = "security_failed@email.com";
        
        public void SignUp(string email)
        {
            if (email == DUPLICATE_EMAIL)
                throw new DuplicateEmailException(DUPLICATE_EMAIL);

            if (email == PERSIST_EMAIL_FAILED)
                throw new PersistEmailException(PERSIST_EMAIL_FAILED, new Exception("Database failure"));

            if (email == BANNED_EMAIL_FAILED)
                throw new BannedEmailException(BANNED_EMAIL_FAILED);
        }
    }
}
