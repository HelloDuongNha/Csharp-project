using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
{
    public static class AccountRepository
    {
        // Attribute and GET SET method for account data
        private static List<object> AccData = new List<object>();
        public static void SetData(List<object> data) { AccData = data; }

        #region method

        public static List<Account> GetAllData()
        {
            using (var db = new Part1DB_Entities())
            {
                var data = from acc in db.Accounts
                           select acc;

                return data.ToList();
            }
        }

        // ################ LOAD DATA INTO DATAGRIDVIEW ################
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

        // ################ GET NEXT AVAILABLE ACCOUNT ID ###############
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

        // ################ ADD A NEW ACCOUNT TO DATABASE ################
        public static void Add_Account(int id, string name, string email, string password)
        {
            using (var db = new Part1DB_Entities())
            {
                string Role = "User";
                DateTime DT = DateTime.Now;

                string hashedPassword = ToMD5(password);

                Account newAccount = new Account(id, name, email, hashedPassword)
                {
                    Id = id,
                    Username = name,
                    Email = email,
                    Password = hashedPassword,
                    IsLogin = false,
                    Role = Role.Trim(),
                    CreatedTime = DT
                };

                db.Accounts.Add(newAccount);
                db.SaveChanges();
            }
        }

        // ################ ENCRYPT PASSWORD WITH MD5 ####################
        private static string ToMD5(string text)
        {
            using (var md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(text);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (var b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        // ################ VERIFY LOGIN CREDENTIALS ####################
        public static Account GetAccountByCredentials(string input, string password)
        {
            string hashedPassword = ToMD5(password);

            using (var db = new Part1DB_Entities())
            {
                foreach (var account in db.Accounts)
                {
                    if ((account.Username == input || account.Email == input) && account.Password == hashedPassword)
                    {
                        return account;
                    }
                }
            }

            return null;
        }

        // ################ UPDATE LOGIN STATUS BY USERNAME/EMAIL ################
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

        // ################ CHECK IF USERNAME EXISTS ####################
        public static bool IsUsernameTaken(string username)
        {
            var accounts = GetAllData();

            string inputUsername = username.Trim().ToLower();

            foreach (Account acc in accounts)
            {
                string existingUsername = acc.Username.Trim().ToLower();
                if (inputUsername == existingUsername)
                {
                    return true; // Username already exists
                }
            }

            return false; // Username does not exist
        }

        // ################ CHECK IF EMAIL EXISTS ####################
        public static bool IsEmailTaken(string email)
        {
            var accounts = GetAllData();

            string inputEmail = email.Trim().ToLower();

            foreach (Account acc in accounts)
            {
                string existingEmail = acc.Email.Trim().ToLower();
                if (inputEmail == existingEmail)
                {
                    return true; // Email already exists
                }
            }

            return false; // Email does not exist
        }

        // ############# GET LOGGED IN ACCOUNT ##################
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

        // ################ LOG OUT CURRENT USER ##################
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

        // ################ DELETE CURRENTLY LOGGED-IN ACCOUNT ##############
        public static void DeleteAccountByLogin()
        {
            using (var db = new Part1DB_Entities())
            {
                var acc = db.Accounts.FirstOrDefault(a => a.IsLogin == true);
                if (acc != null)
                {
                    int id = acc.ID;
                    DeleteAccountById(id);
                }
            }
        }

        // ######### ADMIN: DELETE ACCOUNT BY ID + RELATED DATA ############
        public static void DeleteAccountById(int id)
        {
            using (var db = new Part1DB_Entities())
            {
                var account = db.Accounts.Find(id);
                if (account != null)
                {
                    // Delete related data in RecycleBin
                    var relatedRecycleBin = db.RecycleBins.Where(r => r.AccId == id).ToList();
                    db.RecycleBins.RemoveRange(relatedRecycleBin);

                    // Delete related data in StringProcessing
                    var relatedStringProcessing = db.StringProcessings.Where(s => s.AccId == id).ToList();
                    db.StringProcessings.RemoveRange(relatedStringProcessing);

                    // Delete account
                    db.Accounts.Remove(account);
                    db.SaveChanges();
                }
            }
        }

        // ######### ADMIN: DELETE ALL USER ACCOUNTS + RELATED DATA #########
        public static void DeleteAllUserAccounts()
        {
            using (var db = new Part1DB_Entities())
            {
                var userAccounts = db.Accounts.Where(a => a.Role == "User").ToList();

                foreach (var acc in userAccounts)
                {
                    int id = acc.ID;

                    // Delete related RecycleBin data
                    var relatedRecycleBin = db.RecycleBins.Where(r => r.AccId == id).ToList();
                    db.RecycleBins.RemoveRange(relatedRecycleBin);

                    // Delete related StringProcessing data
                    var relatedStringProcessing = db.StringProcessings.Where(s => s.AccId == id).ToList();
                    db.StringProcessings.RemoveRange(relatedStringProcessing);

                    // Delete account
                    db.Accounts.Remove(acc);
                }

                db.SaveChanges();
            }
        }

        // ################ UPDATE USERNAME + EMAIL FOR LOGGED-IN ACCOUNT ##############
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

        // ########## CHANGE PASSWORD FOR LOGGED-IN ACCOUNT ###########
        public static bool ChangePasswordForLoggedInUser(string currentPassword, string newPassword)
        {
            string hashedCurrent = ToMD5(currentPassword);  // hash old password
            string hashedNew = ToMD5(newPassword);          // hash new password

            using (var db = new Part1DB_Entities())
            {
                var acc = db.Accounts.FirstOrDefault(a => a.IsLogin == true);

                if (acc != null && acc.Password == hashedCurrent)
                {
                    acc.Password = hashedNew;
                    db.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        // ########## GET ACCOUNT CREATED TIME BY ID ############
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
