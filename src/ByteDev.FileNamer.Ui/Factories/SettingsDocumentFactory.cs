using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using ByteDev.FileNamer.Ui.Config;

namespace ByteDev.FileNamer.Ui.Factories
{
    // TODO: delete once sure dont need at all

//    public interface ISettingsDocumentFactory
//    {
//        XmlDocument CreateFor(ProgramSettings settings);
//    }
//
//    public class SettingsDocumentFactory : ISettingsDocumentFactory
//    {
//        private readonly IAppConfig _appConfig;
//
//        public SettingsDocumentFactory(IAppConfig appConfig)
//        {
//            _appConfig = appConfig;
//        }
//
//        public XmlDocument CreateFor(ProgramSettings settings)
//		{
//			var xmlDoc = new XmlDocument();
//			
//			xmlDoc.AppendChild(xmlDoc.CreateElement("filenamer"));
//
//			AddWindowLocationNode(xmlDoc, settings);
//			AddWindowSizeNode(xmlDoc, settings);
//			AddWindowStateNode(xmlDoc, settings);
//			AddFileSuffixNode(xmlDoc, settings);
//			AddFolderNode(xmlDoc, settings);
//			AddAutoPreviewNode(xmlDoc, settings);
//			AddClearOpsOnRenameNode(xmlDoc, settings);
//
//			return xmlDoc;
//		}
//
//		private static void AddClearOpsOnRenameNode(XmlDocument xmlDoc, ProgramSettings settings)
//		{
//			var element = xmlDoc.CreateElement("clear_ops_on_rename");
//			element.InnerText = ToString(settings.ClearOpsOnRename);
//
//			AppendElement(xmlDoc, element);
//		}
//
//        private static void AddAutoPreviewNode(XmlDocument xmlDoc, ProgramSettings settings)
//		{
//			var element = xmlDoc.CreateElement("auto_preview");
//			element.InnerText = ToString(settings.AutoPreview);
//
//            AppendElement(xmlDoc, element);
//		}
//
//        private void AddFolderNode(XmlDocument xmlDoc, ProgramSettings settings)
//		{
//			var element = xmlDoc.CreateElement("folder");
//
//			if (!string.IsNullOrEmpty(settings.Folder))
//			{
//			    var dirInfo = new DirectoryInfo(settings.Folder);
//			    element.InnerText = dirInfo.Exists ? settings.Folder : _appConfig.DirectoryPath;
//			}
//			else
//			{
//				element.InnerText = string.Empty;
//			}
//
//            AppendElement(xmlDoc, element);
//		}
//
//        private static void AddFileSuffixNode(XmlDocument xmlDoc, ProgramSettings settings)
//		{
//			var element = xmlDoc.CreateElement("file_suffix");
//			element.InnerText = ToString(settings.FileSuffix);
//
//            AppendElement(xmlDoc, element);
//		}
//
//        private static void AddWindowStateNode(XmlDocument xmlDoc, ProgramSettings settings)
//		{
//			var element = xmlDoc.CreateElement("window_state");
//			element.InnerText = ToString(settings.WindowState);
//
//            AppendElement(xmlDoc, element);
//		}
//
//        private static void AddWindowSizeNode(XmlDocument xmlDoc, ProgramSettings settings)
//		{
//			var element = xmlDoc.CreateElement("window_size");
//			element.InnerText = ToString(settings.WindowSize);
//
//            AppendElement(xmlDoc, element);
//		}
//
//        private static void AddWindowLocationNode(XmlDocument xmlDoc, ProgramSettings settings)
//		{
//			var element = xmlDoc.CreateElement("window_location");
//			element.InnerText = ToString(settings.WindowLocation);
//			
//            AppendElement(xmlDoc, element);            
//		}
//
//        // Convert an object to a string
//        private static string ToString(object obj)
//		{
//			TypeConverter converter = TypeDescriptor.GetConverter(obj.GetType());
//			return converter.ConvertToString(obj);
//		}
//
//        private static void AppendElement(XmlDocument xmlDoc, XmlElement xmlElement)
//        {
//            if (xmlDoc.DocumentElement == null)
//            {
//                throw new InvalidOperationException("Cannot append child as XML document has no root document element");
//            }
//            xmlDoc.DocumentElement.AppendChild(xmlElement);
//        }
    //}
}
