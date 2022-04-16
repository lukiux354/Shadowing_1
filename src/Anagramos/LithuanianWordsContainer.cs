using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramos
{
    public class LithuanianWordsContainer
    {
        public int Count { get; private set; }
        private LithuanianWords[] AllWords;

        public LithuanianWordsContainer()
        {
            this.AllWords = new LithuanianWords[130000];
            this.Count = 0;
        }
        public void Add(LithuanianWords word)
        {
            AllWords[Count] = word;
            this.Count++;
        }
        public LithuanianWords Get(int index)
        {
            return AllWords[index];
        }
    }
}
