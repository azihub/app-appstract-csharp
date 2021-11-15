using Grpc.Core;
using Grpc.Core.Interceptors;
using Grpc.Core.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Azihub.Appstract.Tests.MockGrpc
{
    public class GlobalServerLoggerInterceptor : Interceptor
    {
        private readonly ILogger logger;

        public GlobalServerLoggerInterceptor(ILogger logger)
        {
            this.logger = logger;
        }

        public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)
        {
            logger.Debug($"{Environment.NewLine}GRPC Request{Environment.NewLine}Method: {context.Method}{Environment.NewLine}Data: {JsonConvert.SerializeObject(request, Formatting.Indented)}");

            var response = await base.UnaryServerHandler(request, context, continuation);

            logger.Debug($"{Environment.NewLine}GRPC Response{Environment.NewLine}Method: {context.Method}{Environment.NewLine}Data: {JsonConvert.SerializeObject(response, Formatting.Indented)}");

            return response;
        }
    }
}
