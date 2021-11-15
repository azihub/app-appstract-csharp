using Azihub.Appstract.Grpc.Interceptors;
using Grpc.AspNetCore.Server;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ProtoBuf.Grpc.Server;

namespace Azihub.Appstract.Grpc.Extensions
{
    public static class GrpcExtensions
    {
        /// <summary>
        /// This extension adds the CodeFirstGrpc and CodeFirstGrpcReflection service methods and registers the AppsAuthRpcExceptionsInterceptor class.
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

        /// <summary>
        /// This extension adds the CodeFirstGrpc and CodeFirstGrpcReflection service methods and registers the AppsAuthRpcExceptionsInterceptor class.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddAndConfigureCodeFirstGrpc(this IServiceCollection services, GrpcServiceOptions options)
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
