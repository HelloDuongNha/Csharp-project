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
    }

}
