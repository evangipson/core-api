using Microsoft.AspNetCore.Mvc.RazorPages;

using CoreApi.Platform.Logic.Providers;

namespace CoreApi.View.Api.ViewModels
{
    public class HomePageModel(IAssemblyProvider assemblyProvider) : PageModel
    {
        public Dictionary<string, string> Endpoints => new()
        {
            ["/response"] ="Gets a basic response.",
            ["/response?query=value"] = "Gets a basic response with a query parameter.",
            ["/response/complex"] = "Gets a complex response.",
            ["/response/complex?vehicle=boat"] = "Gets a complex response with a Boat.",
            ["/users"] = "Gets all users from the user provider asynchronously.",
            ["/users/first"] = "Gets the first user from the user provider asynchronously.",
        };

        public string AssemblyName => assemblyProvider.GetName();

        public string AssemblyVersion => $"v{assemblyProvider.GetVersion()}";

        public string AssemblyDescription => assemblyProvider.GetDescription();
    }
}
