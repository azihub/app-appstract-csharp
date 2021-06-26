using Azihub.AppConsole.Base.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Azihub.AppConsole.Tests
{
    public class GrpcTests
    {
        [Fact]
        public void GrpcServiceTest()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddAndConfigureCodeFirstGrpc();
        }
    }
}
