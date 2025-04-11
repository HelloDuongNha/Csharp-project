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
                foreach (var account in db.Accounts)
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


        #endregion
    }
}
