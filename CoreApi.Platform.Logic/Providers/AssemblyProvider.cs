using System.Reflection;

namespace CoreApi.Platform.Logic.Providers
{
    public class AssemblyProvider : IAssemblyProvider
    {
        private Assembly? _entryAssembly;

        private Assembly EntryAssembly => _entryAssembly ??= Assembly.GetEntryAssembly()!;

        public string GetVersion() => EntryAssembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion;

        public string GetDescription() => EntryAssembly.GetCustomAttribute<AssemblyDescriptionAttribute>()!.Description;

        public string GetName() => EntryAssembly.GetName().Name!.Split('.').FirstOrDefault()!;
    }
}
