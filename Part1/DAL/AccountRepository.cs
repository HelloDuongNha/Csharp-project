using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public static class AccountRepository
    {
        #region method

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
                Account newAccount = new Account(id, name, email, password)
                {
                    Id = id,
                    Username = name,
                    Email = email,
                    Password = password,
                    IsLogin = false
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

        #endregion
    }
}
