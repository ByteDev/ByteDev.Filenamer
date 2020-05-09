using System.Windows.Forms;
using ByteDev.Io.IsolatedStorage;

namespace ByteDev.FileNamer.Ui.Config
{
    public interface IProgramSettingsFactory
    {
        ProgramSettings Create();
    }

    public class ProgramSettingsFactory : IProgramSettingsFactory
    {
        private readonly IAppConfig _appConfig;
        private readonly IsolatedStorageFileName _settingsFileName;

        public ProgramSettingsFactory(IAppConfig appConfig, IsolatedStorageFileName settingsFileName)
        {
            _appConfig = appConfig;
            _settingsFileName = settingsFileName;
        }

        public ProgramSettings Create()
        {
            return new ProgramSettings
            {
                SettingsFileName = _settingsFileName.Name,
                WindowState = FormWindowState.Normal,
                FileSuffix = _appConfig.FileSuffix,
                Folder = _appConfig.DirectoryPath,
                AutoPreview = _appConfig.AutoPreview,
                ClearOpsOnRename = _appConfig.ClearOpsOnRename
            };
        }
    }
}