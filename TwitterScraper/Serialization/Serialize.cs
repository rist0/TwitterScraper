using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TwitterScraper
{
    public static class Serialize
    {
        public static Settings LoadUserData(string filePath)
        {
            Settings settings = null;
            if (File.Exists(filePath))
            {
                settings = BinarySerialization.ReadFromBinaryFile<Settings>(filePath);
            }
            return settings;
        }

        public static void SaveUserData(Settings settings)
        {
            if (!Directory.Exists(Application.StartupPath + "\\data"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\data");
            }
            BinarySerialization.WriteToBinaryFile(Application.StartupPath + "\\data\\data.bin", settings);
        }
    }
}
