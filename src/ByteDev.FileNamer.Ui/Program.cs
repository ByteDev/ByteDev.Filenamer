using System;
using System.Windows.Forms;
using ByteDev.Common.Serialization.Xml;
using ByteDev.FileNamer.Ui.Config;
using ByteDev.FileNamer.Ui.Factories;

namespace ByteDev.FileNamer.Ui
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(CreateMainForm());
        }

        private static MainForm CreateMainForm()
        {
            return new MainForm(new OperationFormFactory(),
                new ProgramSettingsService(CreateProgramSettingsFactory(), new XmlDataSerializer()));
        }

        private static ProgramSettingsFactory CreateProgramSettingsFactory()
        {
            var appConfig = new AppConfig();
            var settingsFileName = IsolatedStorageFileNameFactory.Create();

            return new ProgramSettingsFactory(appConfig, settingsFileName);
        }
    }
}
