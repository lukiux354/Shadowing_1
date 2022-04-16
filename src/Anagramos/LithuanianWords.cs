using System;
using System.IO;

namespace Anagramos
{
    public class LithuanianWords
    {
        public string BaseWord { get; set; }
        public string WordType { get; set; }
        public string Word { get; set; }
        public int HowCommon { get; set; }
        public long WordIDByPrimeNumbers { get; set; }

        public LithuanianWords()
        {
            
        }
        public LithuanianWords(string baseWord, string wordType, string word, int howCommon, long wordIDByPrimeNumbers)
        {
            BaseWord = baseWord;
            WordType = wordType;
            Word = word;
            HowCommon = howCommon;
            WordIDByPrimeNumbers = wordIDByPrimeNumbers;
        }

    }
}
