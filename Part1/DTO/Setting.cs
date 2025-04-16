using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public partial class Setting
    {
        public bool DarkMode { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Mode { get; set; }
        public float Opacity { get; set; }

        public void LoadSetting()
        {
            SettingRepository.Load();
        }

        public Setting GetCurrentSetting()
        {
            return SettingRepository.Load();
        }

        public void SaveSetting(Setting setting)
        {
            SettingRepository.Save(setting);
        }


    }
}
