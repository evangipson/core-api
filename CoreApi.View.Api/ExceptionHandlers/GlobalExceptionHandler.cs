using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace CoreApi.View.Api.ExceptionHandlers
{
    /// <summary>
    /// Implements <see cref="IExceptionHandler"/> to handle exceptions throughout
    /// the application by propagating errors up to the API response.
    /// </summary>
    public class GlobalExceptionHandler : IExceptionHandler
    {
        /// <summary>
        /// Handles any <see cref="InvalidOperationException"/> that is thrown by propagating
        /// the status code on the HTTP response, and the exception's message.
        /// </summary>
        /// <param name="httpContext"></param>
        /// <param name="exception"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            var problemDetails = CreateProblemDetails(httpContext, exception);
            await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);

            return true;
        }

        /// <summary>
        /// Creates an error response using the provided <paramref name="httpContext"/>
        /// and <paramref name="exception"/> to propagate to an HTTP response.
        /// </summary>
        /// <param name="httpContext"></param>
        /// <param name="exception"></param>
        /// <returns>
        /// A <see cref="ProblemDetails"/> filled with error information.
        /// </returns>
        private static ProblemDetails CreateProblemDetails(HttpContext httpContext, Exception exception)
        {
            var reasonPhrase = ReasonPhrases.GetReasonPhrase(httpContext.Response.StatusCode);
            if (string.IsNullOrEmpty(reasonPhrase))
            {
                reasonPhrase = "There was an error.";
            }

            return new()
            {
                Status = httpContext.Response.StatusCode,
                Title = exception.Message ?? reasonPhrase,
            };
        }
    }
}
