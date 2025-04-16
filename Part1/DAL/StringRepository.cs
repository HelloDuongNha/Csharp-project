using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
{
    public static class StringRepository
    {
        // attribute and method for history data
        private static List<object> HistoryData = new List<object>();
        public static void SetData(List<object> data) { HistoryData = data; }
        public static List<object> GetAllData() { return HistoryData; }


        #region method

// ################ GET DATA ######################
        public static int GetLoggedInAccountId()
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
            return 0;
        }

        public static int GetNextHistoryIdForAccount(int accId)
        {
            using (var db = new Part1DB_Entities())
            {
                var lastHistory = db.StringProcessings
                                    .Where(x => x.AccId == accId)
                                    .OrderByDescending(x => x.HistoryId)
                                    .FirstOrDefault();

                return (lastHistory?.HistoryId ?? 0) + 1;
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

// ################# LOAD DATA ######################
        public static void Load_Data(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            HistoryData.Clear();

            int? loggedInAccId = GetLoggedInAccountId();

            if (loggedInAccId == null)
            {
                MessageBox.Show("Please Login First.");
                return;
            }

            using (var db = new Part1DB_Entities())
            {
                var data = from c in db.StringProcessings
                           where c.AccId == loggedInAccId
                           orderby c.Time descending
                           select new { HistoryID = c.HistoryId, S = c.InputS, N = c.InputN, T = c.Time };

                foreach (var item in data)
                {
                    dataGridView.Rows.Add(item.HistoryID, item.S, item.N, item.T);
                    HistoryData.Add(item);
                }

                SetData(HistoryData);
            }
        }


// ################# ADD DATA ######################
        public static void Add_Data(int nextID, String S, String N, DateTime time)
        {
            using (var db = new Part1DB_Entities())

            {
                int loggedInAccId = GetLoggedInAccountId();
                int nextHistoryId = GetNextHistoryIdForAccount(loggedInAccId);
                StringProcessing stringHistory = new StringProcessing(nextID, S, N, time)
                {
                    Id = nextID,
                    InputS = S,
                    InputN = Convert.ToInt32(N),
                    Time = time,
                    AccId = loggedInAccId,
                    HistoryId = nextHistoryId
                };
                db.StringProcessings.Add(stringHistory);
                db.SaveChanges();
            }
        }


// ################# DELELTE DATA ######################
        public static void Delete_Data(int historyId)
        {
            var accId = GetLoggedInAccountId();

            using (var db = new Part1DB_Entities())
            {
                foreach (var item in db.StringProcessings.ToList())
                {
                    if (item.HistoryId == historyId && item.AccId == accId)
                    {
                        db.StringProcessings.Remove(item);
                        db.SaveChanges();
                        break;
                    }
                }
            }
        }

        public static void TruncateTable()
        {
            int? accId = GetLoggedInAccountId();

            using (var db = new Part1DB_Entities())
            {
                var toDelete = new List<StringProcessing>();

                foreach (var item in db.StringProcessings.ToList())
                {
                    if (item.AccId == accId)
                    {
                        toDelete.Add(item);
                    }
                }

                db.StringProcessings.RemoveRange(toDelete);
                db.SaveChanges();
            }
        }
        #endregion
    }
}
