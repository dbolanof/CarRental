using Api.Middlewares;

namespace Api.Extensionss
{
    public static class Middlerware
    {
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
