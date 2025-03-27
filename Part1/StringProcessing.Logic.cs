using System;
using System.Linq;
using Part1.classes;

namespace Part1
{
    public partial class StringProcessing
    {
        // Attribute
        private string _encodedString = "";

        public StringProcessing() { }

        // GET SET
        public string S
        {
            get { return (string)InputS; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Error: The string cannot be null or contain only whitespace.");

                value = value.Replace(" ", "");
                if (!value.All(c => c >= 'A' && c <= 'Z'))
                    throw new ArgumentException("Error: The string must contain only uppercase letters from A to Z.");

                if (value.Length > 40)
                    throw new ArgumentException("Error: The string cannot exceed 40 characters.");

                InputS = value;
            }
        }

        public int N
        {
            get { return InputN ?? 0; }
            set
            {
                if (value < -25 || value > 25)
                    throw new ArgumentException("Error: N must be in the range [-25, 25].");
                InputN = value;
            }
        }

        // Constructor
        public StringProcessing(int nextID, string input, string shift, DateTime time)
        {
            if (string.IsNullOrWhiteSpace(shift))
                throw new ArgumentException("Error: N cannot be empty or contain only whitespace.");

            if (!int.TryParse(shift, out int shiftValue))
                throw new ArgumentException("Error: N must be a valid integer.");

            Id = nextID;
            S = input;
            N = shiftValue;
            Time = time;
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
    }
}
