using System.Globalization;

namespace CustomMiddleware.Middlewares
{
    public class CultureMiddleware
    {
        private readonly RequestDelegate next;

        public CultureMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var cultureQuery = context.Request.Query["culture"];
            if (!string.IsNullOrWhiteSpace(cultureQuery))
            {
                var culture = new CultureInfo(cultureQuery!);

                CultureInfo.CurrentCulture = culture;
                CultureInfo.CurrentUICulture = culture;
            }

            // Call the next delegate/middleware in the pipeline.
            await next(context);
        }
    }

    public static class ExtensionMiddleware
    {
        public static IApplicationBuilder AddCultureDefinition(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CultureMiddleware>();
        }
    }
}
