using Azihub.Appstract.Base.Exceptions;

namespace Azihub.Appstract.Tests.MockService.Exceptions
{
    public class DuplicateEmailException : BusinessLogicException
    {
        public DuplicateEmailException(string emailAddress) : 
            base($"Duplicate email address: {emailAddress}")
        {

        }

        public override int Code => 101;

        public override string LocaleConst => "LOCALE_CONST";
    }
}
