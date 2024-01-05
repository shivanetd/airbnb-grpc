using AirbnbGrpc.Services;
using AirbnbGrpc.Config;
using AirbnbGrpc.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddGrpcReflection();

builder.Services.AddSingleton<IAirbnbRepository, AirbnnRepository>();

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.MapGrpcReflectionService();
    app.UseDeveloperExceptionPage();
}

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<AirbnbService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
