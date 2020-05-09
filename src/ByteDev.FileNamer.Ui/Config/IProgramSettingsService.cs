namespace ByteDev.FileNamer.Ui.Config
{
    public interface IProgramSettingsService
    {
        ProgramSettings ProgramSettings { get; }
        void Save();
        void Load();
    }
}