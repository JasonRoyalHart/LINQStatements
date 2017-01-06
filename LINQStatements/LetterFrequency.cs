using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQStatements
{
    class LetterFrequency
    {
        //Write a function that takes in a string of letters(e.g., "Llewellyn") and returns a alphabetically ordered string
        //corresponding to the letter frequency(e.g., "E2L4N1W1Y1")
        
        public string GetFrequencies(string letters)
        {
            letters = String.Concat(letters.ToUpper().OrderBy(alphabetical => alphabetical));
            Dictionary<string, int> letterCount = new Dictionary<string, int>();
            foreach (char letter in letters)
            {
                letterCount[letter.ToString()] = letters.Count(checkLetter => checkLetter == letter);
            }
            string returnString = "";
            foreach (KeyValuePair<string, int> entry in letterCount)
            {
                returnString += entry.Key;
                returnString += entry.Value;
            }
            return returnString;
        }
    }
}
