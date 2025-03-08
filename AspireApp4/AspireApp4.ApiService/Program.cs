using AspireApp4.ApiService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add API Documentation
builder.Services.AddSwaggerGen();

// Add controllers services
builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddProblemDetails();

// MY SQL Connection
builder.AddMySqlDbContext<DataDbContext>("UserDatabase");

var app = builder.Build();

app.MapControllers();

app.UseSwagger();

app.UseSwaggerUI();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.MapDefaultEndpoints();

app.Run();
