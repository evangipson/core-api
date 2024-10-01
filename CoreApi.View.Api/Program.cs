using CoreApi.View.Api.Extensions;

namespace CoreApi.View.Api
{
    /// <summary>
    /// A class which is referenced when the application starts.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Configures and runs the application.
        /// </summary>
        internal static void Main(string[] args) => WebApplication.CreateBuilder(args)
            .ConfigureBuilder()
            .Build()
            .ConfigureApplication()
            .Run();
    }
}
