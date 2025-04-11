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


        #endregion
    }
}
