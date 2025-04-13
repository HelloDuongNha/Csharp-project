using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Part1
{
    public static class RecycleBinRepository
    {
        private static List<object> DeletedData = new List<object>();
        public static void SetData(List<object> data) { DeletedData = data; }
        public static List<object> GetAllData() { return DeletedData; }


        #region method
        public static int? GetLoggedInAccountId()
        {
            using (var db = new Part1DB_Entities())
            {
                foreach (var acc in db.Accounts.ToList())
                {
                    if (acc.IsLogin == true)
                    {
                        return acc.ID;
                    }
                }
            }
            return null;
        }

        public static void Load_Data(DataGridView BinGridView)
        {
            BinGridView.Rows.Clear();
            DeletedData.Clear();

            int? loggedInAccId = GetLoggedInAccountId();

            if (loggedInAccId == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản nào đang đăng nhập.");
                return;
            }

            using (var db = new Part1DB_Entities())
            {
                var data = from c in db.RecycleBins
                           where c.AccId == loggedInAccId
                           orderby c.DeletedTime descending
                           select new { ID = c.Id, S = c.InputS, N = c.InputN, T = c.Time, DT = c.DeletedTime };

                foreach (var item in data)
                {
                    BinGridView.Rows.Add(item.ID, item.S, item.N, item.T, item.DT);
                    DeletedData.Add(item);
                }

                SetData(DeletedData);
            }
        }

        public static int GenerateUniqueID(int id)
        {
            using (var db = new Part1DB_Entities())
            {
                var allIDs = db.RecycleBins.Select(x => x.Id).ToList();

                while (allIDs.Contains(id)) 
                {
                    id++; 
                }
            }
            return id;
        }



        public static int GetNextID()
        {
            using (var db = new Part1DB_Entities())
            {
                int maxId = 0;
                foreach (var record in db.RecycleBins)
                {
                    if (record.Id > maxId)
                    {
                        maxId = (int)record.Id;
                    }
                }
                return maxId + 1;
            }
        }

        public static int CountRecord()
        {
            using (var db = new Part1DB_Entities())
            {
                return db.RecycleBins.Count();
            }
        }

        public static void Add_Data(int nextID, String textBoxS, String textBoxN, DateTime encodedTime)
        {
            using (var db = new Part1DB_Entities())

            {
                int? loggedInAccId = GetLoggedInAccountId();
                DateTime DT = DateTime.Now;
                RecycleBin recycleBin = new RecycleBin(nextID, textBoxS, textBoxN, encodedTime, DT) 
                {
                    Id = nextID,
                    InputS = textBoxS,
                    InputN = Convert.ToInt32(textBoxN),
                    Time = encodedTime,
                    DeletedTime = DT,
                    AccId = loggedInAccId
                };
                db.RecycleBins.Add(recycleBin);
                db.SaveChanges();
            }
        }

        public static void Delete_Data(int id)
        {
            using (var db = new Part1DB_Entities())
            {
                var record = db.RecycleBins.FirstOrDefault(r => r.Id == id); 

                if (record == null)
                {
                    throw new ArgumentException("Error: The ID does not exist in the RecycleBin table.");
                }

                db.RecycleBins.Remove(record);
                db.SaveChanges();
            }
        }

        public static void RestoreData(int id)
        {
            using (var db = new Part1DB_Entities())
            {
                int? loggedInAccId = GetLoggedInAccountId();
                var record = db.RecycleBins.FirstOrDefault(r => r.Id == id);
                db.StringProcessings.Add(new StringProcessing
                {
                    Id = (int)record.Id,
                    InputS = record.InputS,
                    InputN = record.InputN??0,
                    Time = record.Time,
                    AccId = loggedInAccId
                });
                db.RecycleBins.Remove(record);
                db.SaveChanges();
            }
        }

        public static void TruncateTable()
        {
            using (var db = new Part1DB_Entities())
            {
                db.RecycleBins.RemoveRange(db.RecycleBins);
                db.SaveChanges();
            }
        }

        #endregion
    }
}
