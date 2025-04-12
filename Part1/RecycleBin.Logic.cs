using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Part1.classes;

namespace Part1
{
    public partial class RecycleBin
    {
        public RecycleBin() : base() { }

        public RecycleBin(int nextID, string input, string shift, DateTime time, DateTime deletedTime)
        {
            if (string.IsNullOrWhiteSpace(shift))
                throw new ArgumentException("Error: N cannot be empty or contain only whitespace.");

            if (!int.TryParse(shift, out int shiftValue))
                throw new ArgumentException("Error: N must be a valid integer.");

            Id = nextID;
            InputS = input;
            InputN = shiftValue;
            Time = time;
            DeletedTime = deletedTime;
        }

        public void Display(DataGridView table)
        {
            // Display the recycle bin data in the DataGridView
            RecycleBinRepository.Load_Data(table);
            table.ClearSelection();
        }

        public List<object> GetAllData()
        {
            return RecycleBinRepository.GetAllData();
        }

        public int CountRecord()
        {
            return RecycleBinRepository.CountRecord();
        }

        public int GetUniqueID(int Id)
        {
            return RecycleBinRepository.GenerateUniqueID(Id);
        }

        public void Restore(int Id, String S, String N, DateTime T)
        {
            RecycleBinService.ProcessRestoration(Id, S, N, T);
        }

        public void RestoreAll()
        {
            RecycleBinService.ProcessRestoreAll();
        }

        public void Delete(int id)
        {
            // Delete the item
            RecycleBinRepository.Delete_Data(id);
        }

        public void ClearAll()
        {
            // Clear all the recycle bin
            RecycleBinRepository.TruncateTable();
        }

        public void AddToBin(int originalID, string S, string N, DateTime T)
        {
            // Add an item to the recycle bin (can have the same ID)
            RecycleBinRepository.Add_Data(originalID, S, N, T);
        }
    }

}
