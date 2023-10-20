using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker_Houk
{
    internal class StringManager
    {
        public StringManager()
        {
        }

        // Variable to hold the input string for each method
        private string _input = "";

        // Set the input string
        public void SetInput(string s)
        {
            _input = s;
        }

        // Input a string and return the reverse of the string
        public string Reverse(string s)
        {
            _input = s;
            string reverse = "";
            for (int i = _input.Length - 1; i >= 0; i--)
            {

                reverse += _input[i];
            }
            return reverse;
        }

        // Input a string and return the reverse, keeping the case of
        // the letters by location
        public string Reverse(string s, bool PreserveCaseLocation)
        {
            string reverse = "";
            _input = s;
            for (int i = _input.Length - 1; i >= 0; i--)
            {
                if (Char.IsUpper(_input[_input.Length - 1 - i]))
                    reverse += _input[i].ToString().ToUpper();
                else
                    reverse += _input[i].ToString().ToLower();
            }
            return reverse;
        }

        // Input a string and return true if the string is symmetric
        public bool Symmetric(string s)
        {
            _input = s;
            string reverse = "";
            for (int i = _input.Length - 1; i >= 0; i--)
            {
                reverse += _input[i];
            }
            if (_input == reverse)
                return true;
            else
                return false;
        }

        public string CallToString(string s)
        {
            return s.ToString();
        }
            
        // Return the string as a number
        public override string ToString()
        {
            int sum = 0;

            // If the input string is null or empty, return "Negative One"
            if (string.IsNullOrEmpty(_input))
            {
                return "Negative One";
            }

            // If the input string is not null or empty, sum the ASCII values
            // of the characters
            foreach (char c in _input)
            {
                sum += (int)c;
            }

            // Reassign the sum to a string
            string sumStr = sum.ToString();
            string words = "";

            // Look at each character in the sum string and assign the
            // corresponding word to the words string
            foreach (char c in sumStr)
            {
                switch (c)
                {
                    case '0':
                        words += "Zero ";
                        break;
                    case '1':
                        words += "One ";
                        break;
                    case '2':
                        words += "Two ";
                        break;
                    case '3':
                        words += "Three ";
                        break;
                    case '4':
                        words += "Four ";
                        break;
                    case '5':
                        words += "Five ";
                        break;
                    case '6':
                        words += "Six ";
                        break;
                    case '7':
                        words += "Seven ";
                        break;
                    case '8':
                        words += "Eight ";
                        break;
                    case '9':
                        words += "Nine ";
                        break;
                }
            }
            // Return the sum of ASCII values as a string of words
            return words;
        }

        // Override the Equals method to compare the current data input to the class with a literal or variable string
        public override bool Equals(object? obj)
        {
            //if obj is not a string, return false
            if (!(obj is string))
                return false;
            if (obj == null) return false;
            //if obj is a string, compare it to the current data input
            return obj.ToString() == _input;
        }
    }
}
