using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Part1.classes;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Part1
{
    public static class StringRepository
    {
        private static List<object> HistoryData = new List<object>();
        public static void SetData(List<object> data) { HistoryData = data; }
        public static List<object> GetAllData() { return HistoryData; }


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

        public static void Load_Data(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            HistoryData.Clear();

            int? loggedInAccId = GetLoggedInAccountId();
            MessageBox.Show(loggedInAccId.ToString());

            if (loggedInAccId == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản nào đang đăng nhập.");
                return;
            }

            using (var db = new Part1DB_Entities())
            {
                var data = from c in db.StringProcessings
                           where c.AccId == loggedInAccId
                           orderby c.Time descending
                           select new { ID = c.Id, S = c.InputS, N = c.InputN, T = c.Time };

                foreach (var item in data)
                {
                    dataGridView.Rows.Add(item.ID, item.S, item.N, item.T);
                    HistoryData.Add(item);
                }

                SetData(HistoryData);
            }
        }

        public static int GenerateUniqueID(int id)
        {
            using (var db = new Part1DB_Entities())
            {
                var allIDs = db.StringProcessings.Select(x => x.Id).ToList();

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

                foreach (var record in db.StringProcessings)
                {
                    if (record.Id > maxId)
                    {
                        maxId = record.Id; 
                    }
                }

                return maxId + 1;
            }
        }

        public static int CountRecord()
        {
            using (var db = new Part1DB_Entities())
            {
                int count = db.StringProcessings.Count();
                return count;
            }
        }

        public static void Add_Data(int nextID, String S, String N, DateTime time)
        {
            using (var db = new Part1DB_Entities())

            {
                int? loggedInAccId = GetLoggedInAccountId();
                StringProcessing stringHistory = new StringProcessing(nextID, S, N, time)
                {
                    Id = nextID,
                    InputS = S,
                    InputN = Convert.ToInt32(N),
                    Time = time,
                    AccId = loggedInAccId
                };
                db.StringProcessings.Add(stringHistory);
                db.SaveChanges();
            }
        }

        public static void Delete_Data(int id)
        {
            using (var db = new Part1DB_Entities())
            {
                var data = db.StringProcessings.Find(id);
                if (data != null)
                {
                    db.StringProcessings.Remove(data);
                    db.SaveChanges();
                }
            }
        }

        public static void TruncateTable()
        {
            using (var db = new Part1DB_Entities())
            {
                db.StringProcessings.RemoveRange(db.StringProcessings);
                db.SaveChanges();
            }
        }



        #endregion
    }
}
