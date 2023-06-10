using LoggerBasicWithProvidersWithCustomProvider.Providers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Logging.ClearProviders();
//builder.Logging.AddSimpleConsole(opts =>
//{
//    opts.IncludeScopes = true;
//});


builder.Logging.AddProvider(new CustomConsoleLoggerProvider(() =>
{
    return new ConsoleConfig(ConsoleColor.Green);
}));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
