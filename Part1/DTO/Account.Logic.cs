using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Part1
{
    public partial class Account
    {
        // Private fields
        private int _id;
        private string _username;
        private string _email;
        private string _password;
        private bool _isLogin;

        public int Id
        {
            get => _id;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error: ID cannot be negative.");
                _id = value;
            }
        }

        public string N
        {
            get => _username;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Error: The string cannot be null or contain only whitespace.");

                if (value.Any(char.IsWhiteSpace))
                    throw new ArgumentException("Error: The string cannot contain spaces or whitespace.");

                if (!value.All(c => c >= 'A' && c <= 'Z'))
                    throw new ArgumentException("Error: The string must contain only uppercase letters from A to Z.");

                if (value.Length > 30)
                    throw new ArgumentException("Error: Username cannot exceed 30 characters.");
                _username = value;
            }
        }

        public string E
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Error: Email cannot be empty or whitespace.");
                if (!value.Contains('@') || !value.Contains('.'))
                    throw new ArgumentException("Error: Email format is invalid.");
                _email = value;
            }
        }

        public string P
        {
            get => _password;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Error: Password cannot be empty or whitespace.");
                if (value.Length < 6)
                    throw new ArgumentException("Error: Password must be at least 6 characters long.");
                _password = value;
            }
        }

        public bool I
        {
            get => _isLogin;
            set => _isLogin = value;
        }



        // Constructor 
        public Account(int id, string username, string email, string password, bool isLogin = false)
        {
            Id = id;
            N = username;
            E = email;
            P = password;
            I = isLogin;
            CreatedTime = DateTime.Now;
        }


        // Method
        public int GetNextAccId()
        {
            return AccountRepository.GetNextAccountID();
        }

        public void Add_Account(int nextId, String username, String email, String password)
        {
            AccountRepository.Add_Account(nextId, username, email, password);
        }
    }
}
