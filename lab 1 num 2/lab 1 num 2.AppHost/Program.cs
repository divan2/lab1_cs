var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.lab_1_num_2_ApiService>("apiservice");

builder.AddProject<Projects.lab_1_num_2_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
