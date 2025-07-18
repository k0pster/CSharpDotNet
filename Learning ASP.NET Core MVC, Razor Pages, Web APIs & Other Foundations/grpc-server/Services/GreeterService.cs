using Grpc.Core;
using grpc_server;

namespace grpc_server.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }

    public override Task<HelloReply> GreetNewEmployee(Employee request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Welcome to the company " + request.Name
        });
    }
}
