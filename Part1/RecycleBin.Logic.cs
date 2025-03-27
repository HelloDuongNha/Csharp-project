using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
{
    public partial class RecycleBin : StringProcessing
    {
        public RecycleBin() : base() { }

        public RecycleBin(int nextID, string input, string shift, DateTime time, DateTime deletedTime)
            : base(nextID, input, shift, time)
        {
            DeletedTime = deletedTime;

        }

        public void Restore(int Id, String S, int N, DateTime T)
        {
            RecycleBinService.ProcessRestoration(Id, S, N, T);
        }

        public void Delete(int Id)
        {
            // Delete the item
            RecycleBinService.ProcessDeletion(Id);
        }

        public void ClearAll()
        {
            // Clear all the recycle bin
            RecycleBinService.ProcessClearAll();
        }

        public void RestoreAll()
        {
            RecycleBinService.ProcessRestoreAll();
        }


        public void AddToBin(int Id, string S, int N, DateTime T)
        {
            // Add an item to the recycle bin
            RecycleBinService.ProcessAddingToRecycleBin(Id, S, N, T);
        }
    }

}
