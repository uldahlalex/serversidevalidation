using serversidevalidation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<PetDatabase>();
builder.Services.AddSingleton<PetService>();
builder.Services.AddOpenApiDocument();

builder.Services.AddControllers();

var app = builder.Build();

app.UseOpenApi();
app.UseSwaggerUi();
app.MapControllers();

app.Run();
