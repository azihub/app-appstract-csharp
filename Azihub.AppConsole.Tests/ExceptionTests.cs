using Azihub.AppConsole.Tests.MockService;
using Azihub.AppConsole.Tests.MockService.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Azihub.AppConsole.Tests
{
    public class ExceptionTests
    {
        [Fact]
        public void BusinessExceptionTest()
        {
            SignUpService service = new SignUpService();
            Assert.Throws<DuplicateEmailException>(() => service.SignUp(SignUpService.DUPLICATE_EMAIL));
        }

        [Fact]
        public void ApplicationExceptionTest()
        {
            SignUpService service = new SignUpService();
            Assert.Throws<PersistEmailException>(() => service.SignUp(SignUpService.PERSIST_EMAIL_FAILED));
        }

        [Fact]
        public void SecurityExceptionTest()
        {
            SignUpService service = new SignUpService();
            Assert.Throws<BannedEmailException>(() => service.SignUp(SignUpService.BANNED_EMAIL_FAILED));

        }
    }
}
