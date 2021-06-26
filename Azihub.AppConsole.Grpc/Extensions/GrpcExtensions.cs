using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ProtoBuf.Grpc.Server;
using Azihub.AppConsole.Grpc.Interceptors;

namespace Azihub.AppConsole.Base.Extensions
{
    public static class GrpcExtensions
    {
        /// <summary>
        /// This extension adds the CodeFirstGrpc and CodeFirstGrpcReflection service methods and registers the SsoRpcExceptionsInterceptor class.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddAndConfigureCodeFirstGrpc(this IServiceCollection services)
        {
            services.AddCodeFirstGrpc(config =>
            {
                config.Interceptors.Add(typeof(RpcExceptionsInterceptor));
                config.ResponseCompressionLevel = System.IO.Compression.CompressionLevel.Optimal;
            });

            services.TryAddSingleton(RpcExceptionsInterceptor.Instance);
            services.AddCodeFirstGrpcReflection();

            return services;
        }
    }
}
