var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.VSCode_ApiService>("apiservice");

builder.AddProject<Projects.VSCode_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
