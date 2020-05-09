using ByteDev.Configuration.AppSettings;

namespace ByteDev.FileNamer.Ui.Config
{
    public interface IAppConfig
    {
        string FileSuffix { get; }

        string DirectoryPath { get; }

        bool AutoPreview { get; }

        bool ClearOpsOnRename { get; }
    }

    public class AppConfig : IAppConfig
    {
        private readonly IAppSettingsProvider _provider;

        public AppConfig()
        {
            _provider = new AppSettingsProvider();
        }

		public string FileSuffix => _provider.GetString("FileSuffix");

        public string DirectoryPath => _provider.GetString("DirPath");

        public bool AutoPreview => _provider.GetBool("AutoPreview");

        public bool ClearOpsOnRename => _provider.GetBool("ClearOpsOnRename");
    }
}
