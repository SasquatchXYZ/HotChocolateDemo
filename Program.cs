using HotChocolateDemo.GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    // Returns an `IRequestExecutorBuilder`, which has many extension methods
    // that can be used to configure the GraphQL schema
    .AddGraphQLServer()
    // We are specifying the Query type that should be exposed by our GraphQL server
    .AddQueryType<Query>();

var app = builder.Build();

// app.MapGet("/", () => "Hello World!");
app.MapGraphQL();

app.Run();
