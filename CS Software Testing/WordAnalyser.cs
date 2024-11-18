using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Software_Testing
{
    public class WordAnalyser
    {
        public List<string> FindLongestWords(string text)
        {
            // TODO: Implement the logic to find the longest word(s) in the given text
            string[] words = text.Split(" ");
            List<string> longestWords = new List<string>();
            int length = 0;

            foreach (string word in words)
            {
                if (word.Length > length) length = word.Length;
            }

            foreach (string s in words)
            {
                if (s.Length >= length)
                {
                    longestWords.Add(s);
                }
            }

            return longestWords;
        }

        public Dictionary<char, int> CalculateLetterFrequency(string text)
        {
            // TODO: Implement the logic to calculate the frequency of each letter in the given text
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for(char letter = 'a';  letter <= 'z'; letter++)
            {
                dictionary.Add(letter, 0);
            }


            foreach (char c in text)
            {
                if(dictionary.ContainsKey(Char.ToLower(c)))
                {
                    dictionary[Char.ToLower(c)]++;
                }
            }
            return dictionary;
        }
    }
}
