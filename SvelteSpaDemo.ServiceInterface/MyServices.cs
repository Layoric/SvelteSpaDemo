using System;
using ServiceStack;
using SvelteSpaDemo.ServiceModel;

namespace SvelteSpaDemo.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
