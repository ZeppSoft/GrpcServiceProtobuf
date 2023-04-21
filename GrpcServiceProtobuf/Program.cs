using GrpcServiceProtobuf.Services;
using ProtoBuf.Grpc.Server;
using ProtoBuf.Meta;
using Shared;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddCodeFirstGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<LoanManager>();
app.MapGrpcService<CwnetService>();
app.MapGrpcService<TestService>();



RuntimeTypeModel.Default.Add(typeof(Any.Container), false).SetSurrogate(typeof(Any));


app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
