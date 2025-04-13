using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
{
    public static class SettingRepository
    {
        private const string FilePath = @"C:/Users/hoang/source/repos/Part1/Part1/Resources/Settings.txt";

        public static Setting Load()
        {
            var setting = new Setting();

            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('=');
                    if (parts.Length != 2) continue;

                    var key = parts[0].Trim();
                    var value = parts[1].Trim();

                    if (key.Equals("DarkMode", StringComparison.OrdinalIgnoreCase))
                    {
                        if (bool.TryParse(value, out bool darkModeValue))
                        {
                            setting.DarkMode = darkModeValue;
                        }
                    }
                    else if (key.Equals("Width", StringComparison.OrdinalIgnoreCase))
                    {
                        if (int.TryParse(value, out int width))
                        {
                            setting.Width = width;
                        }
                    }
                    else if (key.Equals("Height", StringComparison.OrdinalIgnoreCase))
                    {
                        if (int.TryParse(value, out int height))
                        {
                            setting.Height = height;
                        }
                    }
                    else if (key.Equals("Mode", StringComparison.OrdinalIgnoreCase))
                    {
                        setting.Mode = value;
                    }
                    else if (key.Equals("Opacity", StringComparison.OrdinalIgnoreCase))
                    {
                        if (int.TryParse(value, out int opacity))
                        {
                            setting.Opacity = (float)opacity;
                        }
                    }
                }
            }

            return setting;
        }


        public static void Save(Setting setting)
        {
            var lines = new List<string>
            {
                $"DarkMode={setting.DarkMode}",
                $"Width={setting.Width}",
                $"Height={setting.Height}",
                $"Mode={setting.Mode}",
                $"Opacity={setting.Opacity}"
            };
            File.WriteAllLines(FilePath, lines);
        }
 



    }
}
