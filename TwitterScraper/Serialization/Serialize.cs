using System.IO;
using System.Windows.Forms;

namespace TwitterScraper.Serialization
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