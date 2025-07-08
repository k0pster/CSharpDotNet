using Grpc.Core;
using grpc_server;

namespace grpc_server.Services;

public class WebDevService : WebDev.WebDevBase 

{
    public override Task<ProjectConfirmation> CreateProject(Project request, ServerCallContext context)
    {
        return Task.FromResult(new ProjectConfirmation
        {
            Msg = $"New project created: {request.Name}"
        });
    }
}