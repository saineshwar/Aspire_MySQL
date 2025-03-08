var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

// MySQL Database With PhpMyAdmin
var mysql = builder.AddMySql("MySQLDB")
    .WithDataVolume()
    .WithPhpMyAdmin();

// MySQL Database
var mysqldb = mysql 
   
    .AddDatabase("UserDatabase");

var apiService = builder.AddProject<Projects.AspireApp4_ApiService>("apiservice")
    .WithReference(mysqldb)
    .WaitFor(mysqldb);

builder.AddProject<Projects.AspireApp4_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
