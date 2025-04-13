using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Crmf;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
namespace Part1
{
    public static class SettingService
    {
        private static Setting _setting;

        // Gọi hàm này khi app chạy lần đầu
        public static void LoadSettings()
        {
            _setting = SettingRepository.Load();
        }

        public static void SaveSettings()
        {
            SettingRepository.Save(_setting);
        }

        //public static void ToggleDarkMode(bool enabled, TabPage[] tabPages, Form inputForm)
        //{
        //    _setting.DarkMode = enabled;
        //    SaveSettings(); // Cập nhật Settings.txt
        //    ApplyDarkMode(tabPages, enabled, inputForm); // Đổi lại màu
        //}

        public static void ApplyDarkMode(TabPage[] tabPages, bool enabled, Form inputForm)
        {
            _setting.DarkMode = enabled;
            SaveSettings(); // Cập nhật Settings.txt
            // DARK MODE MÀU
            Color formBackColor = enabled ? Color.FromArgb(30, 30, 30) : SystemColors.Control;
            Color tabBackColor = enabled ? Color.FromArgb(50, 50, 50) : SystemColors.ActiveCaption;
            Color groupBackColor = enabled ? Color.FromArgb(80, 80, 80) : Color.WhiteSmoke;
            Color textColor = enabled ? Color.White : Color.Black;
            Color buttonBackColor = enabled ? Color.FromArgb(60, 60, 60) : SystemColors.Control;
            Color gridBackColor = enabled ? Color.FromArgb(60, 60, 60) : Color.White;
            Color gridTextColor = enabled ? Color.White : Color.Black;
            Color gridHeaderBackColor = enabled ? Color.FromArgb(40, 40, 40) : Color.LightGray;
            Color gridHeaderTextColor = enabled ? Color.White : Color.Black;

            // Cập nhật màu Form
            inputForm.BackColor = formBackColor;

            // Duyệt các Tab
            foreach (TabPage tab in tabPages)
            {
                tab.BackColor = tabBackColor;
                tab.ForeColor = textColor;

                // Duyệt từng GroupBox trong Tab
                foreach (Control control in tab.Controls)
                {
                    if (control is GroupBox groupBox)
                    {
                        groupBox.BackColor = groupBackColor;
                        groupBox.ForeColor = textColor;

                        foreach (Control groupControl in groupBox.Controls)
                        {
                            if (groupControl is Label lbl)
                            {
                                lbl.ForeColor = textColor;
                            }

                            if (groupControl is Button btn)
                            {
                                btn.BackColor = buttonBackColor;
                                btn.ForeColor = textColor;
                            }

                            if (groupControl is DataGridView dgv)
                            {
                                if (enabled)
                                {
                                    // DARK MODE
                                    dgv.BackgroundColor = gridBackColor;
                                    dgv.DefaultCellStyle.BackColor = gridBackColor;
                                    dgv.DefaultCellStyle.ForeColor = gridTextColor;
                                    dgv.ColumnHeadersDefaultCellStyle.BackColor = gridHeaderBackColor;
                                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = gridHeaderTextColor;
                                    dgv.EnableHeadersVisualStyles = false;
                                }
                                else
                                {
                                    // LIGHT MODE
                                    // Đặt lại màu sắc cho DataGridView ở chế độ Light Mode theo màu đã chỉ định
                                    dgv.BackgroundColor = Color.White; // Màu nền sáng
                                    dgv.DefaultCellStyle.BackColor = Color.White; // Màu nền của các ô
                                    dgv.DefaultCellStyle.ForeColor = Color.Black; // Màu chữ đen
                                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy; // Màu nền header sáng
                                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Màu chữ header trắng
                                    dgv.EnableHeadersVisualStyles = false; // Bắt buộc để áp dụng header style

                                    // Gọi hàm setup DataGridView tương ứng
                                    if (dgv.Name == "dgvString")
                                    {
                                        StringService.SetupDataGridView(dgv); // Cấu hình lại String DataGridView
                                    }
                                    else if (dgv.Name == "dgvRecycleBin")
                                    {
                                        RecycleBinService.SetupDataGridView(dgv); // Cấu hình lại Recycle Bin DataGridView
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static bool IsDarkModeEnabled()
        {
            return _setting.DarkMode;
        }


        public static void BindSettingToControls(RadioButton radioOn, RadioButton radioOff, RadioButton window, RadioButton fullscreen, NumericUpDown widthBox, NumericUpDown heightBox, TrackBar opacity)
        {
            var setting = SettingRepository.Load();
            _setting = setting;

            // Bind dark mode
            if (setting.DarkMode)
            {
                radioOn.Checked = true;
                radioOff.Checked = false;
            }
            else
            {
                radioOff.Checked = true;
                radioOn.Checked = false;
            }

            // Bind resolution
            widthBox.Value = setting.Width;
            heightBox.Value = setting.Height;
            opacity.Value = Convert.ToInt32(setting.Opacity);  // Convert opacity to range 0-100

            // Bind mode
            if (setting.Mode == "Fullscreen")
            {
                fullscreen.Checked = true;
                window.Checked = false;
            }
            else
            {
                window.Checked = true;
                fullscreen.Checked = false;
            }
        }

        // Lưu độ phân giải vào _setting
        public static void LoadResolution(int width, int height, Form formToResize)
        {
            _setting.Width = width;
            _setting.Height = height;
            SaveSettings();

            // Cập nhật lại form size
            formToResize.Width = width;
            formToResize.Height = height;

            // Gọi lại CenterContent sau khi resize
            CenterTabControl(formToResize);
        }

        public static void UpdWidth(int width, Form form)
        {
            _setting.Width = width;

            // Chỉ chuyển chế độ nếu đang ở Window
            if (_setting.Mode == "Window")
            {
                // Chuyển sang chế độ Window và cập nhật lại form
                form.FormBorderStyle = FormBorderStyle.Sizable;
                form.WindowState = FormWindowState.Normal;
                form.TopMost = false;
            }

            // Lưu và cập nhật độ phân giải
            SaveSettings();
            LoadResolution(_setting.Width, _setting.Height, form);
        }

        public static void UpdHeight(int height, Form form)
        {
            _setting.Height = height;

            // Chỉ chuyển chế độ nếu đang ở Window
            if (_setting.Mode == "Window")
            {
                // Chuyển sang chế độ Window và cập nhật lại form
                form.FormBorderStyle = FormBorderStyle.Sizable;
                form.WindowState = FormWindowState.Normal;
                form.TopMost = false;
            }

            // Lưu và cập nhật độ phân giải
            SaveSettings();
            LoadResolution(_setting.Width, _setting.Height, form);
        }


        public static void CenterTabControl(Form form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is TabControl tabControl)
                {
                    int centerX = (form.ClientSize.Width - tabControl.Width) / 2;
                    int centerY = (form.ClientSize.Height - tabControl.Height) / 2;

                    tabControl.Location = new Point(Math.Max(0, centerX), Math.Max(0, centerY));
                    break;
                }
            }
        }

        public static void ApplyMode(Form form, NumericUpDown widthBox, NumericUpDown heightBox)
        {
            if (_setting.Mode == "Fullscreen")
            {
                // Fullscreen Mode: Mở rộng toàn màn hình, cập nhật kích thước từ setting
                form.FormBorderStyle = FormBorderStyle.Sizable; // vẫn có thanh tiêu đề
                form.WindowState = FormWindowState.Maximized;   // full màn hình
                form.TopMost = true;

                // Cập nhật tỷ lệ độ phân giải
                int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

                LoadResolution(screenWidth, screenHeight, form);

                // Chuyển các NumericUpDown thành readonly
                widthBox.ReadOnly = true;
                heightBox.ReadOnly = true;
                widthBox.Enabled = false;
                heightBox.Enabled = false;
            }
            else
            {
                // Window Mode: Chế độ cửa sổ bình thường, về kích thước 800x500
                form.FormBorderStyle = FormBorderStyle.Sizable;
                form.TopMost = false;
                form.WindowState = FormWindowState.Normal;

                // Khi trở lại window, giữ lại kích thước mặc định (800 x 500)
                LoadResolution(800, 500, form);

                // Bỏ readonly cho các NumericUpDown khi về chế độ Window
                widthBox.ReadOnly = false;
                heightBox.ReadOnly = false;
                widthBox.Enabled = true;
                heightBox.Enabled = true;
            }
        }


        public static void SaveMode(string mode)
        {
            _setting.Mode = mode;
            SaveSettings();
        }

        // Hàm để lưu opacity
        // Lưu giá trị opacity
        public static void SaveOpacity(int opacityValue)
        {
            // Chuyển opacity từ 0-100 thành 0.0 - 1.0
            _setting.Opacity = opacityValue;
            SaveSettings();
        }

        // Áp dụng opacity cho form
        public static void ApplyOpacity(Form form)
        {
            if (_setting.Opacity >= 0 && _setting.Opacity <= 100)
            {
                form.Opacity = _setting.Opacity/100f;
            }
        }

    }
}

