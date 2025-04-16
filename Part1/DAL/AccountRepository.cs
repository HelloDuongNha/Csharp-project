using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
{
    public static class AccountRepository
    {
        private static List<object> AccData = new List<object>();
        public static void SetData(List<object> data) { AccData = data; }
        #region method

        public static List<Account> GetAllData()
        {
            using (var db = new Part1DB_Entities())
            {
                // Truy vấn tất cả tài khoản mà không có điều kiện
                var data = from acc in db.Accounts
                           select acc;

                return data.ToList(); // Trả về tất cả tài khoản
            }
        }

        public static void Load_Data(DataGridView AccGridView)
        {
            AccGridView.Rows.Clear();
            AccData.Clear();

            using (var db = new Part1DB_Entities())
            {
                var data = from acc in db.Accounts
                           where acc.Role == "User"
                           orderby acc.CreatedTime descending
                           select new
                           {
                               Id = acc.ID,
                               Username = acc.Username,
                               Email = acc.Email,
                               CreatedTime = acc.CreatedTime,
                               TotalRecords = db.StringProcessings.Count(sp => sp.AccId == acc.ID)
                           };

                foreach (var item in data)
                {
                    AccGridView.Rows.Add(item.Id, item.Username, item.Email, item.TotalRecords);
                    AccData.Add(item);
                }

                SetData(AccData);
            }
        }

        public static int GetNextAccountID()
        {
            using (var db = new Part1DB_Entities())
            {
                int maxId = 0;

                foreach (var record in db.Accounts)
                {
                    if (record.Id > maxId)
                    {
                        maxId = record.Id;
                    }
                }

                return maxId + 1;
            }
        }

        public static void Add_Account(int id, String name, String email, String password)
        {
            using (var db = new Part1DB_Entities())
            {
                string Role = "User";
                DateTime DT = DateTime.Now;
                Account newAccount = new Account(id, name, email, password)
                {
                    Id = id,
                    Username = name,
                    Email = email,
                    Password = password,
                    IsLogin = false,
                    Role = Role.Trim(),
                    CreatedTime = DT
                };

                db.Accounts.Add(newAccount);
                db.SaveChanges();
            }
        }

        public static Account GetAccountByCredentials(string input, string password)
        {
            using (var db = new Part1DB_Entities())
            {
                foreach (var account in db.Accounts)
                {
                    if ((account.Username == input || account.Email == input) && account.Password == password)
                    {
                        return account;
                    }
                }
            }
            return null; 
        }

        public static void SetLoginStatus(string usernameOrEmail, bool status)
        {
            using (var db = new Part1DB_Entities())
            {
                var accounts = db.Accounts.ToList();

                foreach (var account in accounts)
                {
                    if (account.Username == usernameOrEmail || account.Email == usernameOrEmail)
                    {
                        account.IsLogin = status;
                        db.SaveChanges(); 
                        break;
                    }
                }
            }
        }

        public static bool IsUsernameTaken(string username)
        {
            var accounts = GetAllData();

            string inputUsername = username.Trim().ToLower();

            foreach (Account acc in accounts)
            {
                string existingUsername = acc.Username.Trim().ToLower();
                if (inputUsername == existingUsername)
                {
                    return true; // Username đã tồn tại
                }
            }

            return false; // Username chưa tồn tại
        }

        public static bool IsEmailTaken(string email)
        {
            var accounts = GetAllData();

            string inputEmail = email.Trim().ToLower();

            foreach (Account acc in accounts)
            {
                string existingEmail = acc.Email.Trim().ToLower();
                if (inputEmail == existingEmail)
                {
                    return true; // Email đã tồn tại
                }
            }

            return false; // Email chưa tồn tại
        }

        public static Account GetLoggedInAccount()
        {
            using (var db = new Part1DB_Entities())
            {
                foreach (var account in db.Accounts.ToList())
                {
                    if (account.IsLogin == true)
                    {
                        return account; 
                    }
                }
            }
            return null;
        }

        public static void LogOutCurrentUser()
        {
            using (var db = new Part1DB_Entities())
            {
                foreach (var account in db.Accounts.ToList())
                {
                    if (account.IsLogin == true)
                    {
                        account.IsLogin = false;
                        db.SaveChanges();
                        break;
                    }
                }
            }
        }
        public static void DeleteAccountByLogin()
        {
            using (var db = new Part1DB_Entities())
            {
                var acc = db.Accounts.FirstOrDefault(a => a.IsLogin == true);
                if (acc != null)
                {
                    int id = acc.ID;

                    // Xóa dữ liệu liên quan trong RecycleBin
                    var relatedRecycleBin = db.RecycleBins.Where(r => r.AccId == id).ToList();
                    db.RecycleBins.RemoveRange(relatedRecycleBin);

                    // Xóa dữ liệu liên quan trong StringProcessing
                    var relatedStringProcessing = db.StringProcessings.Where(s => s.AccId == id).ToList();
                    db.StringProcessings.RemoveRange(relatedStringProcessing);

                    // Xóa tài khoản
                    var accountToDelete = db.Accounts.Find(id);
                    if (accountToDelete != null)
                    {
                        db.Accounts.Remove(accountToDelete);
                    }

                    db.SaveChanges();
                }
            }
        }

        public static void DeleteAccountById(int id)
        {
            using (var db = new Part1DB_Entities())
            {
                var account = db.Accounts.Find(id);
                if (account != null)
                {
                    // Xóa dữ liệu liên quan trong RecycleBin
                    var relatedRecycleBin = db.RecycleBins.Where(r => r.AccId == id).ToList();
                    db.RecycleBins.RemoveRange(relatedRecycleBin);

                    // Xóa dữ liệu liên quan trong StringProcessing
                    var relatedStringProcessing = db.StringProcessings.Where(s => s.AccId == id).ToList();
                    db.StringProcessings.RemoveRange(relatedStringProcessing);

                    // Xóa tài khoản
                    db.Accounts.Remove(account);

                    db.SaveChanges();
                }
            }
        }

        public static void DeleteAllUserAccounts()
        {
            using (var db = new Part1DB_Entities())
            {
                var userAccounts = db.Accounts.Where(a => a.Role == "User").ToList();

                foreach (var acc in userAccounts)
                {
                    int id = acc.ID;

                    // Xóa RecycleBin liên quan
                    var relatedRecycleBin = db.RecycleBins.Where(r => r.AccId == id).ToList();
                    db.RecycleBins.RemoveRange(relatedRecycleBin);

                    // Xóa StringProcessing liên quan
                    var relatedStringProcessing = db.StringProcessings.Where(s => s.AccId == id).ToList();
                    db.StringProcessings.RemoveRange(relatedStringProcessing);

                    // Xóa tài khoản
                    db.Accounts.Remove(acc);
                }

                db.SaveChanges();
            }
        }

        public static void UpdateLoggedInAccountInfo(string newUsername, string newEmail)
        {
            using (var db = new Part1DB_Entities())
            {
                var account = db.Accounts.FirstOrDefault(a => a.IsLogin == true);
                if (account != null)
                {
                    account.Username = newUsername;
                    account.Email = newEmail;
                    db.SaveChanges();
                }
            }
        }

        public static bool ChangePasswordForLoggedInUser(string currentPassword, string newPassword)
        {
            using (var db = new Part1DB_Entities())
            {
                var acc = db.Accounts.FirstOrDefault(a => a.IsLogin == true);
                if (acc != null && acc.Password == currentPassword)
                {
                    acc.Password = newPassword;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public static DateTime? GetCreatedTimeById(int id)
        {
            using (var db = new Part1DB_Entities())
            {
                var account = db.Accounts.FirstOrDefault(a => a.ID == id);
                return account?.CreatedTime;
            }
        }

        #endregion
    }
}
