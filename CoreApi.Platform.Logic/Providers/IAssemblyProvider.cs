namespace CoreApi.Platform.Logic.Providers
{
    public interface IAssemblyProvider
    {
        public string GetVersion();

        public string GetDescription();

        public string GetName();
    }
}
