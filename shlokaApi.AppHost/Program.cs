var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.shlokaApi>("shlokaapi");

builder.Build().Run();
