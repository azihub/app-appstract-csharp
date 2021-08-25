using Azihub.Appstract.Grpc.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Azihub.Appstract.Tests
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
