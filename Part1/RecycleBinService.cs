using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Part1
{
    public class RecycleBinService
    {
        public static void SetupDataGridView(TextBox textBoxS, TextBox textBoxN, DataGridView BinGridView)
        {
            BinGridView.Columns.Clear();
            BinGridView.RowHeadersWidth = 30;
            BinGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            BinGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BinGridView.AllowUserToAddRows = false;

            // Căn giữa toàn bộ header
            BinGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cột ID
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "ID";
            idColumn.Width = 25;
            idColumn.ReadOnly = true;
            idColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa cell
            BinGridView.Columns.Add(idColumn);

            // Cột S (Không căn giữa)
            DataGridViewTextBoxColumn inputSColumn = new DataGridViewTextBoxColumn();
            inputSColumn.Name = "StringS";
            inputSColumn.HeaderText = "S";
            inputSColumn.MinimumWidth = 100;
            inputSColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            inputSColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            inputSColumn.Resizable = DataGridViewTriState.False;
            // Không thiết lập Alignment để giữ nguyên mặc định (căn trái)
            BinGridView.Columns.Add(inputSColumn);

            // Cột N
            DataGridViewTextBoxColumn inputNColumn = new DataGridViewTextBoxColumn();
            inputNColumn.Name = "NumberN";
            inputNColumn.HeaderText = "N";
            inputNColumn.Width = 25;
            inputNColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa cell
            BinGridView.Columns.Add(inputNColumn);

            // Cột Time
            DataGridViewTextBoxColumn createdAtColumn = new DataGridViewTextBoxColumn();
            createdAtColumn.Name = "Time";
            createdAtColumn.HeaderText = "Created at";
            createdAtColumn.Width = 130;
            createdAtColumn.ReadOnly = true;
            createdAtColumn.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"; // Định dạng ngày giờ
            createdAtColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa cell
            createdAtColumn.DefaultCellStyle.Font = new Font("Arial", 8); // Font nhỏ hơn cho cột Time
            BinGridView.Columns.Add(createdAtColumn);

            // Cột DTime
            DataGridViewTextBoxColumn deletedAtColumn = new DataGridViewTextBoxColumn();
            deletedAtColumn.Name = "DeletedTime";
            deletedAtColumn.HeaderText = "Deleted At";
            deletedAtColumn.Width = 130;
            deletedAtColumn.ReadOnly = true;
            deletedAtColumn.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"; // Định dạng ngày giờ
            deletedAtColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa cell
            deletedAtColumn.DefaultCellStyle.Font = new Font("Arial", 8); // Font nhỏ hơn cho cột Time
            BinGridView.Columns.Add(deletedAtColumn);

            // Tùy chỉnh giao diện header
            BinGridView.EnableHeadersVisualStyles = false;
            BinGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            BinGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            BinGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            // Đặt font mặc định cho toàn bộ DataGridView (cỡ 10)
            BinGridView.DefaultCellStyle.Font = new Font("Arial", 10);
        }

        public static void LoadAllDataFromDB(DataGridView binGridView)
        {
            RecycleBinRepository.Load_Data(binGridView);
        }

        public static int GetNextId()
        {
            return RecycleBinRepository.GetNextID();
        }

        public static int CountRecords()
        {
            return RecycleBinRepository.CountRecord();
        }

        public static void AddToRecycleBin(DataGridView dataGridView, DataGridView BinGridView)
        {
            string textBoxS = dataGridView.SelectedRows[0].Cells["StringS"].Value?.ToString();
            string textBoxN = dataGridView.SelectedRows[0].Cells["NumberN"].Value?.ToString();
            string encodedTimeStr = dataGridView.SelectedRows[0].Cells["Time"].Value?.ToString();

            if (string.IsNullOrEmpty(textBoxS) || string.IsNullOrEmpty(textBoxN) || string.IsNullOrEmpty(encodedTimeStr))
            {
                MessageBox.Show("Invalid data! Some required fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime encodedTime = DateTime.Parse(encodedTimeStr);
            int nextID = RecycleBinRepository.GetNextID();

            RecycleBinRepository.Add_Data(nextID, textBoxS, textBoxN, encodedTime, BinGridView);
        }


        public static void addBinding(TextBox textBoxS, TextBox textBoxN, TextBox Time, TextBox DTime, TextBox Date, TextBox DDate, DataGridView dataGridView)
        {
            textBoxS.DataBindings.Clear();
            textBoxN.DataBindings.Clear();
            Time.DataBindings.Clear();
            DTime.DataBindings.Clear();

            if (dataGridView.SelectedRows.Count > 0)
            {
                textBoxS.Text = dataGridView.SelectedRows[0].Cells["StringS"].Value?.ToString();
                textBoxN.Text = dataGridView.SelectedRows[0].Cells["NumberN"].Value?.ToString();
                Time.Text = dataGridView.SelectedRows[0].Cells["Time"].Value?.ToString().Split(' ')[1];
                DTime.Text = dataGridView.SelectedRows[0].Cells["DeletedTime"].Value?.ToString().Split(' ')[1];
                Date.Text = dataGridView.SelectedRows[0].Cells["Time"].Value?.ToString().Split(' ')[0];
                DDate.Text = dataGridView.SelectedRows[0].Cells["DeletedTime"].Value?.ToString().Split(' ')[0];
            }
        }

        public static void DeleteFromRecycleBin(int id)
        {
            try
            {
                RecycleBinRepository.DeleteData(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void RestoreFromRecycleBin(int id)
        {
            try
            {
                RecycleBinRepository.RestoreData(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ClearRecycleBin()
        {
            if (CountRecords() == 0)
            {
                MessageBox.Show("Recycle Bin is already empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to permanently clear the recycle bin?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                RecycleBinRepository.ClearData();
                MessageBox.Show("Recycle Bin cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void RestoreAll()
        {
            if (CountRecords() == 0)
            {
                MessageBox.Show("There are no items to restore.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var db = new Part1DB_Entities())
                {
                    var deletedItems = db.RecycleBins.ToList();
                    foreach (var record in deletedItems)
                    {
                        RecycleBinRepository.RestoreData(record.Id);
                    }
                }
                MessageBox.Show("All items restored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error restoring items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
