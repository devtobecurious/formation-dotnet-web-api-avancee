using ProblemDetails.Errors;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddTransient<IProblemDetailsWriter, CustomProblemeDetailsWriter>();


builder.Services.AddProblemDetails(options =>
    options.CustomizeProblemDetails = ctx =>
            ctx.ProblemDetails.Extensions.Add("nodeId", $"{Environment.MachineName} gni"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Environment.IsProduction())
{
    app.UseExceptionHandler("/Error");
}

app.Use(async (context, next) =>
{
    await next(context);
    var mathErrorFeature = context.Features.Get<MathErrorFeature>();
    if (mathErrorFeature is not null)
    {
        if (context.RequestServices.GetService<IProblemDetailsWriter>() is { } problemDetailsService)
        {

            if (problemDetailsService.CanWrite(new ProblemDetailsContext() { HttpContext = context }))
            {
                //(string Detail, string Type) details = mathErrorFeature.MathError switch
                //{
                //    MathErrorType.DivisionByZeroError => ("Divison by zero is not defined.",
                //        "https://en.wikipedia.org/wiki/Division_by_zero"),
                //    _ => ("Negative or complex numbers are not valid input.",
                //        "https://en.wikipedia.org/wiki/Square_root")
                //};

                await problemDetailsService.WriteAsync(new ProblemDetailsContext
                {
                    HttpContext = context,
                    ProblemDetails =
                    {
                        Title = "Bad Input",
                        Detail = "Details bcp",
                        Type = "Type"
                    }
                });
            }
        }
    }
});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.MapGet("/divide", (HttpContext context, double numerator, double denominator) =>
{
    if (denominator == 0)
    {
        var errorType = new MathErrorFeature
        {
            MathError = "DivisionByZeroError"
        };
        context.Features.Set(errorType);
        return Results.BadRequest();
    }

    return Results.Ok(numerator / denominator);
});

app.Run();
