using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Googlese
{
    public class Translator
    {
        Dictionary<char,char> english;

        List<char> googlese = new List<char>()
        {'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p','o', 'n', 'm', 'l', 'k', 
            'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a'}
        ;

        public Translator()
        {
            InitializeDictionary();
        }

        private void InitializeDictionary()
        {
            int asciiStart = Convert.ToInt16('a');
            int asciiEnd = asciiStart + 26;
            int googleseIndex = 0;

            english = new Dictionary<char, char>();

            for (int i = asciiStart; i < asciiEnd; i++ )
            {
                // add the the english characters
                char letter = Convert.ToChar(i);
                english.Add(googlese[googleseIndex], letter);

                // move the list counter
                googleseIndex++;
            }

        }

        public string Translate(string input)
        {
            StringBuilder result = new StringBuilder();

            char[] charArray = input.ToCharArray();

            foreach ( char c in charArray )
            {
                if (c == ' ')
                {
                    result = result.Append(' ');
                }
                else if (english.ContainsKey(c))
                {
                    result.Append(english[c]);
                }
                else
                {
                    result = new StringBuilder("Invalid input, cannot translate.");
                    return result.ToString();
                }
            }

            return result.ToString();
        }
    }
}
