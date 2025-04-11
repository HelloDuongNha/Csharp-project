using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Part1.classes;

namespace Part1
{
    public partial class StringProcessing
    {
        // Attribute
        private int _Id;
        private string _InputS;
        private Nullable<int> _InputN;
        private Nullable<System.DateTime> _Time;
        private string _encodedString = "";

        public StringProcessing() { }

        // GET SET
        public int ID
        {
            get => _Id;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error: ID cannot be negative.");
                _Id = value;
            }
        }
        public string S
        {
            get { return (string)_InputS; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Error: The string cannot be null or contain only whitespace.");

                if (value.Any(char.IsWhiteSpace))
                    throw new ArgumentException("Error: The string cannot contain spaces or whitespace.");

                if (!value.All(c => c >= 'A' && c <= 'Z'))
                    throw new ArgumentException("Error: The string must contain only uppercase letters from A to Z.");

                if (value.Length > 40)
                    throw new ArgumentException("Error: The string cannot exceed 40 characters.");

                _InputS = value;
            }
        }

        public int N
        {
            get { return _InputN ?? 0; }
            set
            {
                if (value < -25 || value > 25)
                    throw new ArgumentException("Error: N must be in the range [-25, 25].");
                _InputN = value;
            }
        }

        public DateTime T
        {
            get { return _Time ?? DateTime.Now; }
            set { _Time = value; }
        }

        // Constructor
        public StringProcessing(int nextID, string input, string shift, DateTime time)
        {
            if (string.IsNullOrWhiteSpace(shift))
                throw new ArgumentException("Error: N cannot be empty or contain only whitespace.");

            if (!int.TryParse(shift, out int shiftValue))
                throw new ArgumentException("Error: N must be a valid integer.");

            ID = nextID;
            S = input;
            N = shiftValue;
            T = time;
        }

        // Methods
        public void Encode()
        {
            _encodedString = StringService.Encode(S, N);
        }

        public string Print()
        {
            return _encodedString;
        }

        public string Sort()
        {
            return StringService.Sort(S);
        }

        public int[] InputCode()
        {
            return StringService.InputCode(S);
        }

        public int[] OutputCode()
        {
            return StringService.OutputCode(_encodedString);
        }

        public void Display(DataGridView table)
        {
            StringRepository.Load_Data(table);
            table.ClearSelection();
        }

        public List<object> GetAllData()
        {
            return StringRepository.GetAllData();
        }

        public int CountRecord()
        {
            return StringRepository.CountRecord();
        }

        public int GetNextID()
        {
            return StringRepository.GetNextID();
        }

        public int GetUniqueID(int id)
        {
            return StringRepository.GenerateUniqueID(id);
        }

        public void AddToHistory(int id, string s, string n, DateTime t)
        {
            StringRepository.Add_Data(id, s, n, t);
        }

        public void Delete(int id)
        {
            StringRepository.Delete_Data(id);
        }

        public void Reset()
        {
            StringRepository.TruncateTable();
        }
    }
}
