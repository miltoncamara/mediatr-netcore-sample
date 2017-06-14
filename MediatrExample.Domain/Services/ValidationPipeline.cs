using MediatR;
using MediatrExample.Domain.Models;
using System.Threading.Tasks;

namespace MediatrExample.Domain.Services
{
    public class ValidationPipeline<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : EntityBase where TResponse : Response
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next)
        {
            if (!((EntityBase)request).IsValid())
            {
                var response = (TResponse)new Response(((EntityBase)request).Notifications, true);
                return response;
            }

            var result = await next();
            return result;
        }
    }
}
