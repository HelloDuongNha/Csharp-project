using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public partial class RecycleBin : StringProcessing
    {
        public RecycleBin() : base() { }

        public RecycleBin(int nextID, string input, string shift, DateTime deletedTime)
            : base(nextID, input, shift)
        {
            DeletedTime = deletedTime;

        }

        public void Display()
        {
            // Display the recycle bin
        }

        public void Restore()
        {
            // Restore the deleted item
        }

        public void Delete()
        {
            // Delete the item
        }

        public void ClearAll()
        {
            // Clear all the recycle bin
        }

        public void RestoreAll()
        {
            // Restore all items in the recycle bin
        }

        public void AddToBin()
        {
            // Add an item to the recycle bin
        }
    }

}
