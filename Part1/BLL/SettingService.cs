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

// ################ LOAD & SAVE SETTINGS ################
        public static void LoadSettings()
        {
            Setting setting = new Setting();
            setting.LoadSetting();
        }

        public static void SaveSettings()
        {
            Setting setting = new Setting();
            setting.SaveSetting(_setting);
        }

// ################# BIND SETTINGS TO CONTROLS ################
        public static void BindSettingToControls(RadioButton radioOn, RadioButton radioOff, RadioButton window, RadioButton fullscreen, NumericUpDown widthBox, NumericUpDown heightBox, TrackBar opacity)
        {
            Setting s = new Setting();
            var setting = s.GetCurrentSetting();
            _setting = s.GetCurrentSetting();

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
            opacity.Value = Convert.ToInt32(setting.Opacity);  

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

// ################# DARK MODE #####################
        public static void ApplyDarkMode(TabPage[] tabPages, bool enabled, Form inputForm)
        {
            _setting.DarkMode = enabled;
            SaveSettings();

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

            // Update form background color
            inputForm.BackColor = formBackColor;

            // Loop through each TabPage
            foreach (TabPage tab in tabPages)
            {
                tab.BackColor = tabBackColor;
                tab.ForeColor = textColor;

                // GroupBox in Tab
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
                                    dgv.BackgroundColor = Color.White; 
                                    dgv.DefaultCellStyle.BackColor = Color.White; 
                                    dgv.DefaultCellStyle.ForeColor = Color.Black; 
                                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy; 
                                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                                    dgv.EnableHeadersVisualStyles = false;

                                    // DataGridView setup
                                    if (dgv.Name == "dataGridView")
                                    {
                                        StringService.SetupDataGridView(dgv);
                                    }
                                    else if (dgv.Name == "BinGridview")
                                    {
                                        RecycleBinService.SetupDataGridView(dgv);
                                    }
                                    else if (dgv.Name == "AccGridview")
                                    {
                                        AccountService.SetupDataGridView(dgv);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

// ################## RESOLUTION #####################
        public static void LoadResolution(int width, int height, Form formToResize)
        {
            _setting.Width = width;
            _setting.Height = height;
            SaveSettings();

            formToResize.Width = width;
            formToResize.Height = height;

            CenterTabControl(formToResize);
        }

        public static void UpdWidth(int width, Form form)
        {
            _setting.Width = width;

            // Only change mode if currently in Window mode
            if (_setting.Mode == "Window")
            {
                // change to Window mode and update the form
                form.FormBorderStyle = FormBorderStyle.Sizable;
                form.WindowState = FormWindowState.Normal;
                form.TopMost = false;
            }

            // save and update the resolution
            SaveSettings();
            LoadResolution(_setting.Width, _setting.Height, form);
        }

        public static void UpdHeight(int height, Form form)
        {
            _setting.Height = height;

            //only change mode if currently in Window mode
            if (_setting.Mode == "Window")
            {
                // change to Window mode and update the form
                form.FormBorderStyle = FormBorderStyle.Sizable;
                form.WindowState = FormWindowState.Normal;
                form.TopMost = false;
            }

            // save and update the resolution
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


// ################# MODE #########################
        public static void ApplyMode(Form form, NumericUpDown widthBox, NumericUpDown heightBox)
        {
            if (_setting.Mode == "Fullscreen")
            {
                // Fullscreen Mode
                form.FormBorderStyle = FormBorderStyle.Sizable; 
                form.WindowState = FormWindowState.Maximized;   
                form.TopMost = true;

                // update the form size to the screen size
                int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

                LoadResolution(screenWidth, screenHeight, form);

                // change the NumericUpDown to readonly
                widthBox.ReadOnly = true;
                heightBox.ReadOnly = true;
                widthBox.Enabled = false;
                heightBox.Enabled = false;
            }
            else
            {
                // Window Mode
                form.FormBorderStyle = FormBorderStyle.Sizable;
                form.TopMost = false;
                form.WindowState = FormWindowState.Normal;

                //default resolution
                LoadResolution(800, 500, form);

                // remove the readonly property
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

// ################ OPACITY ######################
        public static void SaveOpacity(int opacityValue)
        {
            _setting.Opacity = opacityValue;
            SaveSettings();
        }

        public static void ApplyOpacity(Form form)
        {
            if (_setting.Opacity >= 0 && _setting.Opacity <= 100)
            {
                form.Opacity = _setting.Opacity/100f;
            }
        }


// ################ RESET ######################
        public static void ResetToDefault(Form form, TabPage[] tabPages,
                                  RadioButton radioOff, RadioButton windowMode,
                                  NumericUpDown widthBox, NumericUpDown heightBox,
                                  TrackBar opacityBar)
        {
            _setting = new Setting
            {
                Width = 800,
                Height = 500,
                Mode = "Window",
                DarkMode = false,
                Opacity = 100
            };

            SaveSettings(); 

            // update the form
            ApplyMode(form, widthBox, heightBox);           
            ApplyDarkMode(tabPages, false, form);            
            ApplyOpacity(form);                              
            CenterTabControl(form);

            // update the controls
            radioOff.Checked = true;
            windowMode.Checked = true;
            widthBox.Value = 800;
            heightBox.Value = 500;
            opacityBar.Value = 100;
        }
    }
}

