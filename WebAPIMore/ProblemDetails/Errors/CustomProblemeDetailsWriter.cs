namespace ProblemDetails.Errors
{
    public class CustomProblemeDetailsWriter : IProblemDetailsWriter
    {
        public bool CanWrite(ProblemDetailsContext context) => context.HttpContext.Response.StatusCode == 400;

        public ValueTask WriteAsync(ProblemDetailsContext context)
        {
            var response = context.HttpContext.Response;
            return new ValueTask(response.WriteAsJsonAsync(context.ProblemDetails));
        }
    }
}
