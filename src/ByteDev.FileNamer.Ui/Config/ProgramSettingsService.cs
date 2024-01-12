using System;
using ByteDev.Xml.Serialization;
using IsolatedStorageIo = ByteDev.FileNamer.Ui.IsolatedStorage.IsolatedStorageIo;

namespace ByteDev.FileNamer.Ui.Config
{
    public class ProgramSettingsService : IProgramSettingsService
    {
        private readonly IsolatedStorageIo _isolatedStorageIo;
        private readonly IProgramSettingsFactory _programSettingsFactory;
        private readonly IXmlDataSerializer _serializer;

        public ProgramSettings ProgramSettings { get; private set; }
        
		public ProgramSettingsService(IProgramSettingsFactory programSettingsFactory,
            IXmlDataSerializer serializer)
		{
		    _isolatedStorageIo = new IsolatedStorageIo();

		    _programSettingsFactory = programSettingsFactory;
		    _serializer = serializer;

		    ProgramSettings = _programSettingsFactory.Create();
		}

        public void Save()
		{
            var xml = _serializer.Serialize(ProgramSettings);

			_isolatedStorageIo.Write(IsolatedStorageFileNameFactory.Create(), xml);
		}
        
        public void Load()
		{
			try 
			{
				var xml = _isolatedStorageIo.Read(IsolatedStorageFileNameFactory.Create());

			    ProgramSettings = _serializer.Deserialize<ProgramSettings>(xml);
			}
			catch(Exception)
			{
				// If setting dont exist then load from default
                ProgramSettings = _programSettingsFactory.Create();
			}
		}
	}
}