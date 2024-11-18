using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Software_Testing
{
    public class StringManipulator
    {
        public static string ReverseString(string input)
        {
            string result = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }

            return result;
        }

        public static bool IsPalindrome(string input)
        {
            string[] newInput = input.Split(' ');
            input = String.Join("", newInput);

            if(ReverseString(input.ToLower()) == input.ToLower()) return true;
            else return false;
        }
    }
}
