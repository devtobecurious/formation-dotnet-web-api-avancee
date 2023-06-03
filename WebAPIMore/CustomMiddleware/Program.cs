using CustomMiddleware.Middlewares;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();
app.AddCultureDefinition();

//app.Use(async (context, next) =>
//{
//    var cultureQuery = context.Request.Query["culture"];
//    if (!string.IsNullOrWhiteSpace(cultureQuery))
//    {
//        var culture = new CultureInfo(cultureQuery!);

//        CultureInfo.CurrentCulture = culture;
//        CultureInfo.CurrentUICulture = culture;
//    }

//    // Call the next delegate/middleware in the pipeline.
//    await next(context);
//});

app.Run();
