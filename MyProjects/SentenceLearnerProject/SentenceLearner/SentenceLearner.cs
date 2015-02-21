using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceLearner
{
    class SentenceLearner
    {
        private int _SentenseIndex;

        private class TextSet
        {
            public string Japanese;
            public string English;
        }

        private TextSet[] model = 
        {
            new TextSet{Japanese="この池は、冬には凍る", English="This pond freezes in the winter."},
            new TextSet{Japanese="その２人の子は似た顔をしている", English="The two children look alike."},
            new TextSet{Japanese="水中に住んでいる虫は多い", English="Many insects live in water."}            
        };

        private readonly int maxIndex;

        public SentenceLearner()
        {
            _SentenseIndex = -1;
            maxIndex = model.Count();
        }

        public string GetJapanese()
        {
            return model[GetIndex()].Japanese;
        }

        private int GetIndex()
        {
            _SentenseIndex++;

            if(_SentenseIndex >= maxIndex)
            {
                _SentenseIndex = 0;
            }

            return _SentenseIndex;
        }

        public void GetWords(Action<string> action)
        {
            var words = model[_SentenseIndex].English.Split(new char[] { ' ' });

            var ramdomWords = RandomWords(words);
            foreach(var word in ramdomWords)
            {
                action(word);
            }
        }

        public List<string> RandomWords(string[] words)
        {
            var random = new Random();
            var dic = new Dictionary<int, string>();
 
            foreach(var word in words)
            {
                dic.Add(random.Next(), word);
            }
            
            var randomWords = from n in dic
                              orderby n.Key
                              select n;

            var wordList = new List<string>();
            foreach(var randomWord in randomWords)
            {
                wordList.Add(randomWord.Value);
            }

            return wordList;
        }
    }
}
