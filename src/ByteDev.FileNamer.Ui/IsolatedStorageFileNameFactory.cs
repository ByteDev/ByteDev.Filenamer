using System;
using System.Windows.Forms;
using ByteDev.Io.IsolatedStorage;

namespace ByteDev.FileNamer.Ui
{
    public class IsolatedStorageFileNameFactory
    {
        public static IsolatedStorageFileName Create()
        {
            return new IsolatedStorageFileName("FileNamer", new Version(Application.ProductVersion), "xml");
        }
    }
}