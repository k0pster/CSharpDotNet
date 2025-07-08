using Grpc.Net.Client;
using grpc_client;

var channel = GrpcChannel.ForAddress("http://localhost:5224");

var webDevClient = new WebDev.WebDevClient(channel);

var webDevReply = webDevClient.CreateProject(new Project { Name = "Update Website", Id = 5});


Console.WriteLine(webDevReply.Msg);